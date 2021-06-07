using System;
using System.Collections.Generic;
using System.Text;

namespace Evreka.Views
{
    public class MasterPageItem
    {
        public string title;
        public Type targetType;

        public string Title { get => title; set => title = value; }
        public Type TargetType { get => targetType; set => targetType = value; }
    }
}
