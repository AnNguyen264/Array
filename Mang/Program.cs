using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region mang
            /*
            int [] ktem = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ktem{0}:{1}", i, ktem[i]);
            }
            #endregion
            //string[] ktem = new string[] { "howktem", "free education" };
            int[] intarray = { 3, 9, 10 };
            */
            #endregion

            /*
             * Khai báo mảng 2 chiều kiểu string và có tên là ktem.
             * Sau đó thực hiện cấp phát vùng nhớ với số dòng là 2 và số cột là 3.
             */
            #region mang2chieu
            //string[,] Array = new string[2, 3];
            //string[,] ktem = new string[,]
            //{
            //    {"Howkteam","Free education" },
            //    {"Howktem.com","Share to be better"}
            //};
            //int[,] K = new int[,] { {1,2,3,4,5},
            //                        {1,2,3,4,6},  
            //                      };
            #endregion#

            #region vd
            int[,] ktem =
            {
                {1,2 },
                {3,4},
                {5,6}
            };

            // duyet theo dong
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {

            //    }
            //}
            //// duyet theo cot
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {

            //    }
            //}
            #endregion
            /*
             * Getlength(0) sẽ trả về số dòng của mảng 2 chiều 
             * Getlength(1) sẽ trả về số cột của mảng 2 chiều 
             */
            //    int[,] Intarray = {
            //            {1,2,3},
            //            {4,5,6},
            //            {7,8,9}
            //    };
            //    for (int i = 0; i < Intarray.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < Intarray.GetLength(1); j++)
            //        {
            //            Console.Write("{0,5}", Intarray[i, j]);
            //        }
            //        Console.WriteLine();
            //    }

            #region vd2
            // khai bao
            int rows;
            string s;
            bool number;

            //kiemtra
            do
            {
                Console.WriteLine("Nhap so dong cua mang");
                s= Console.ReadLine();
                number=int.TryParse(s, out rows);
                if (!number)
                {
                    Console.WriteLine("Yeu cau nhap lai day k phai so");
                }
            } while (!number);

            Console.WriteLine("So dong la: "+rows);

            // khai bao
            int colums;
            string am;

            //kiemtra
            do
            {
                Console.WriteLine("Nhap so cot cua mang");
                am = Console.ReadLine();
                number = int.TryParse(am, out colums);
                if (!number)
                {
                    Console.WriteLine("Yeu cau nhap lai day k phai so");
                }
            } while (!number);

            Console.WriteLine("so cot da nhap la:" + colums);
            // tao 1  mang 2 chieu voi so dong va so cot dc nhap vao
            int[,] a=new int[rows,colums];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("nhap phan tu cua a[{0},{1}] = ", i, j);
                   a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            // in ra mang 2 chieu va tong 
            int sum = 0;
            for(int i=0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                    sum += a[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("tong gia tri " + sum);
            #endregion
        }
    }
}