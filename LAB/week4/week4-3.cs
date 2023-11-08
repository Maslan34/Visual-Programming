using System;
using System.Collections;

namespace CollectionApplication
{
    class myCollection
    {
        static void Main(string[] args)
        {
            var containerList = new ArrayList();
            var myArrayList = new ArrayList() { 1, "Muharrem", 2.0, true, null};
            ArrayList myArrayList2 = new ArrayList();
            myArrayList2.Add(10);
            myArrayList2.Add("Aslan");
            myArrayList2.Add(20.0);
            myArrayList2.Add(false);
            myArrayList2.Add(null);

            int[] myArray = new int [5] { 100, 200, 300, 400, 500 };
            Queue myQue = new Queue();
            myQue.Enqueue("Huriye");
            myQue.Enqueue("Aslan");

            // Farklı yapılar kullanılıyor burada.

            containerList.AddRange(myQue);
            containerList.AddRange(myArray);
            containerList.AddRange(myArrayList2);
            containerList.AddRange(myArrayList);


            // Accessing Array Lists
            var myCollectionList = new ArrayList() {
                    1,
                    "Yusuf Aslan",
                    300,
                    4.5f
                };

            int firsElement = (int)myCollectionList[0];
            string secondElement = (string)myCollectionList[1];

            foreach(var item in myCollectionList)
            {
                Console.WriteLine(item);
            }




         
        }
    }
}