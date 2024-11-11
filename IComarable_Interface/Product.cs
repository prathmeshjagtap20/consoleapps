using System;
namespace IComarable_Interface
{
    internal class Product:IComparable
    {
        public int productId { get; set; }
        public string name { get; set; }

        public int price { get; set; }
        public int Quantity { get; set; }




         public Product(int productId, string name, int price, int Quantity)
        {
           this.productId=productId;
           this.name=name;
           this.price=price;
           this.Quantity=Quantity;

        }


        public override string ToString()
        {
            return productId+" "+name+"   Price:"+price+" Quantity:- "+Quantity;
        }


        // public int CompareTo(object? obj)
        // {
        //     Product e1= obj as Product;
        //     if(this.productId<e1.productId)
        //     {
        //         return -1;
        //     }

        //     else if (this.productId>e1.productId)
        //     {
        //         return 1;
        //     }

        //     else
        //     {
        //         return 0;
          
        // }


        public int CompareTo(object obj)
        {
            Product e1=obj as Product;
            return string.Compare(name,e1.name);
        }
    }
}