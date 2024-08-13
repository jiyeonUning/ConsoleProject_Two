using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Items
{
    public class ItemBasic
    {
        public int id;
        public string name;
        public string explain;
    }

    public class ItemBuilder
    {
        public int id;
        public string name;
        public string explain;

        public ItemBuilder()
        {
            id = 0;
            name = "아이템이름";
            explain = "설명이 들어간다";
        }

        public ItemBasic Build()
        {
            ItemBasic item = new ItemBasic();
            item.id = id;
            item.name = name;
            item.explain = explain;
            return item;
        }

        public void SetID(int id) { this.id = id; }
        public void SetName(string name) { this.name = name; }
        public void SetExplain(string explain) { this.explain = explain; }
    }
}
