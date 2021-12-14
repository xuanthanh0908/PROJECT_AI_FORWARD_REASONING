using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDBenhGa.Common
{
    class Rules
    {
        #region Field
        /// <summary>
        /// khai bảo biến index dùng đẻ lấy chỉ số
        /// </summary>
        int index;

        /// <summary>
        /// khai báo biến left kiểu danh sách dùng để lưu trữ vế trái của luật
        /// </summary>
        List<string> left;

        /// <summary>
        /// khai báo biến right kiểu danh sách dùng để lưu trữ vé phải của luật
        /// </summary>
        List<string> right;

        /// <summary>
        /// khai báo biến used dùng để kiểm tra luật đã được sử dụng hay chưa
        /// </summary>
        bool used;
        #endregion Field

        #region Property
        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        public List<string> Left
        {
            get { return left; }
            set { left = value; }
        }


        public List<string> Right
        {
            get { return right; }
            set { right = value; }
        }


        public bool Used
        {
            get { return used; }
            set { used = value; }
        }
        #endregion Property

        #region Constructor
        public Rules()
        {
            left = new List<string>();
            right = new List<string>();
        }

        public Rules(int _index, List<string> _left, List<string> _right, bool _used)
        {
            index = _index;
            left = _left;
            right = _right;
            used = _used;
        }
        #endregion Constructor
    }
}
