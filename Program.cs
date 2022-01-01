using System;

namespace DualProperty
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var pi = typeof(MyRelatedDataEntity).GetProperties();
            Console.WriteLine("{0} properties", pi.Length);
        }

        private class MyRelatedDataEntity : RelatedDataEntity<long, object>
        {
            public override object RelatedEntity { get; set; }
        }

        private class RelatedDataEntity<TKey, TEntity>
        {
            public virtual TEntity RelatedEntity { get; set; }
        }

    }
}
