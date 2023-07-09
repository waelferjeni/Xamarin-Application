using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpexam
{
    public class magasinFlyoutMenuItem
    {
        public magasinFlyoutMenuItem()
        {
            TargetType = typeof(magasinFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string Iconsource { get; set; }

    }
}