using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CDBenhGa.Common
{
    class Data
    {
        public List<Rules> get_rule(DataTable RULE)
        {
            List<Rules> rules = new List<Rules>();
            for (int i = 0; i < RULE.Rows.Count; i++)
            {
                Rules rule = new Rules();
                string str = RULE.Rows[i][1].ToString();
                string ri = RULE.Rows[i][2].ToString();
                rule.Index = i;
                Regex RE1 = new Regex(@" \^ ");
                rule.Left.AddRange(RE1.Split(str.Trim()));
                rule.Right.Add(ri);
                rule.Used = false;
                rules.Add(rule);
            }
            return rules;

        }
        public List<string> get_KL(DataTable KL_table)
        {
            List<string> KL = new List<string>();
            int i = 0;
            while (i < KL_table.Rows.Count)
            {
                KL.Add(KL_table.Rows[i][0].ToString());
                i++;
            }
            return KL;
        }
        public void TG_union_right(Rules rule, List<string> TG)
        {
            for (int i = 0; i < rule.Right.Count; i++)
                if (!TG.Contains(rule.Right[i])) TG.Add(rule.Right[i]);
        }

        public bool check_SAT(List<Rules> SAT)
        {
            if (SAT.Count == 0) return false;
            for (int i = 0; i < SAT.Count; i++)
                if (!SAT[i].Used) return true;
            return false;
        }
        public List<Rules> LOC(List<Rules> rules, List<string> TG)
        {
            bool chk;
            List<Rules> LOC_rules = new List<Rules>();
            for (int i = 0; i < rules.Count; i++)
            {
                if (rules[i].Used == false)
                {
                    chk = true;
                    for (int j = 0; j < rules[i].Left.Count; j++)
                        if (TG.Contains(rules[i].Left[j].ToString())) chk = chk && true;
                        else chk = chk && false;
                    if (chk)
                    {
                        LOC_rules.Add(rules[i]);
                    }
                }
            }
            return LOC_rules;
        }

       
        public Rules get_one_rule(List<Rules> SAT)
        {
            int i = 0;
            while (i < SAT.Count)
            {
                if (SAT[i].Used == false)
                {
                    SAT[i].Used = true;
                    break;
                }
                i++;
            }
            return SAT[i];
        }
        public List<int> forward_reasoning(DataTable KL_table, DataTable RULE_table, List<string> GT)
        {
            List<int> kq = new List<int>();

            List<string> KL = new List<string>();
            List<Rules> SAT = new List<Rules>();
            List<Rules> rules = new List<Rules>();
            List<string> TG = new List<string>();
            rules = get_rule(RULE_table);
            KL = get_KL(KL_table);
            TG = GT;
            SAT = LOC(rules, TG);
            while (check_SAT(SAT))
            {
                TG_union_right(get_one_rule(SAT), TG);
                SAT.AddRange(LOC(rules, TG));
            }
            for (int i = 0; i < KL.Count; i++)
                if (TG.Contains(KL[i])) kq.Add(i);
            return kq;
        }
    }
}
