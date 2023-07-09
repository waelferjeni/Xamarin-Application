using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpexam
{
    public class admindbFlyoutMenuItem
    {
        public admindbFlyoutMenuItem()
        {
            TargetType = typeof(admindbFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string Iconsource { get; set; }
    }
}