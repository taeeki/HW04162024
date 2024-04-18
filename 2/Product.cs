using SecondTask;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SecondTask
{
    internal abstract class Product
    {
        protected string Name;
        protected int Price;
        protected int ExpirationDate;
        protected DateTime DayOfManufacture;

        public virtual string Info()
        {
            return string.Format("Название продукта - {0}\nЦена - {1}", Name, Price);
        }

        public virtual bool IsCorrespondsToExpire(DateTime currentDate)
        {
            return (currentDate < DayOfManufacture + new TimeSpan(ExpirationDate, 0, 0, 0));
        }
    }
    internal class Commodity : Product
    {
        public Commodity(string name, int price, DateTime dayofman, int expirat)
        {
            Name = name;
            Price = price;
            DayOfManufacture = dayofman;
            ExpirationDate = expirat;
        }

        public override string Info()
        {
            return base.Info() +
                string.Format("\nДата производства - {0}\nСрок годности - {1} дней",
                              DayOfManufacture, ExpirationDate);

        }
    }

    internal class Batch : Product
    {
        private readonly int _count;

        public Batch(string name, int price, int count, DateTime dateofman, int expir)
        {
            Name = name;
            Price = price;
            _count = count;
            DayOfManufacture = dateofman;
            ExpirationDate = expir;
        }
        public override string Info()
        {
            return base.Info() +
                   string.Format("\nКоличество - {0}\nДата производства - {1}\nСрок годности - {2} дней",
                                 _count, DayOfManufacture, ExpirationDate);
        }
    }

    internal class Complect : Product
    {
        private readonly string _list;

        public Complect(string name, int price, string list)
        {
            Name = name;
            Price = price;
            _list = list;
        }
        public override bool IsCorrespondsToExpire(DateTime currentDate)
        {
            return true;
        }
    }
}