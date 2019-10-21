using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaractUnice();
            //Palindrome();
            //LastWord();
            //Sum_Avg_Vect();
            //IndexElem();
            //DeleteIndex();
            //InsertElement();
            //MaxMinVect();
            //ElementeComune();
            //Array2NewArr();
            DeleteDupl();
            Console.ReadLine();



        }


        private static void CaractUnice()
        {
            int x = 0, y = 0;
            string a;
            Console.WriteLine("introduceti un cuvant: ");
            a = Console.ReadLine();

            for (int i = 0; i < a.Length; i++)
            {
                x = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if(a[i]!=a[j])
                    {
                        x++;
                    }

                }
                if(x==a.Length-1)
                {
                    y++;
                }
                

            }

            if(y==a.Length)
            {
                Console.WriteLine("Toate caracterele sunt unice");
            }
            else
            {
                Console.WriteLine("Elementele nu sunt unice");
            }


        }

        private static void Palindrome()
        {
            int i, j = 0, z = 0;
            string a;
            Console.WriteLine("introduceti un cuvant: ");
            a = Console.ReadLine();
            int[] b = new int[a.Length];

            for ( i = a.Length - 1; i >= 0; i--)
            {

                b[j] = a[i];
                j++;


            }

            for ( i = 0; i < a.Length; i++)
            {
                if(b[i]==a[i])
                {
                    z++;
                }
            }
            if(z==a.Length)
            {
                Console.WriteLine("cuvantul este palindrom");
            }
            else
            {
                Console.WriteLine("cuvanul nu este un palindrom");
            }
         


        }

        private static void LastWord()
        {
            int x = 0;
            string a;
            Console.WriteLine("introduceti un text: ");
            a = Console.ReadLine();


            for (int i = a.Length - 1; i >= 0; i--)
            {
                if(a[i]==' ')
                {
                    break;
                }
                else
                {
                    x++;
                }
            }

            Console.WriteLine("Ultimul cuvant din text are dimensiunea {0}", x);


        }
            
        private static void Sum_Avg_Vect()
        {
            int n, i;
            int[] a = new int[100];
            Console.WriteLine("Introduceti dimensiunea vectorului ");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 0; i < n; i++)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }


            int sum = 0;
            for ( i = 1; i < n; i++)
            {


                sum = a[i - 1] + a[i];
                a[i] = sum;


            }
            Console.WriteLine("Suma elementelor din vector este: {0}",sum);
            Console.WriteLine("Media elementelor din vector este: {0}", Convert.ToDouble(sum / n));
        }

        private static void IndexElem()
        {
            int n, i, x;
            int[] a = new int[100];
            Console.WriteLine("Introduceti dimensiunea vectorului ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Introduceti elementul al carui index verti sa il aflati: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine("elementul cautat se afla pe pozitia: {0}", i);
                }

            }
        }

        private static void DeleteIndex()
        {
            int n, i, x;
            int[] a = new int[100];
            Console.WriteLine("Introduceti dimensiunea vectorului ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Introduceti indexul pe care vreti sa il stergeti: ");
            x = Convert.ToInt32(Console.ReadLine());

            for ( i = x; i < n; i++)
            {
                a[i] = a[i + 1];

            }

            Console.WriteLine("Noul vector este: ");
            for ( i = 0; i < n-1; i++)
            {
                Console.WriteLine("a[{0}]={1}",i,a[i] );

            }


        }

        private static void InsertElement()
        {
            int n, i, index, element;
            int[] a = new int[100];
            Console.WriteLine("Introduceti dimensiunea vectorului ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Introduceti indexul la care vreti sa introduceti un element: ");
            index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti elementul nou: ");
            element = Convert.ToInt32(Console.ReadLine());

            for ( i = 0; i < n; i++)
            {
                if(i==index)
                {
                    a[i] = element;
                }

            }

            Console.WriteLine("Noul vector este: ");
            for ( i = 0; i < n; i++)

            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }

        }

        private static void MaxMinVect()
        {
            int i, n, max, min;
            int[] a = new int[100];

            Console.WriteLine("Introduceti marimea vectorului: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Introduceti elementul {0}= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = a[0];
            min = a[0];

            for (i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                else
                {
                    min = a[i];
                }
            }

            Console.WriteLine("elementul maxim din vector este: " + max);
            Console.WriteLine("elementul minim din vector este: " + min);
        }




    

    private static void ElementeComune()
    {
        int i, j, x = 0, n, m, k = 0, z;
        int[] vector = new int[100];
        int[] vector2 = new int[100];
        int[] vector3 = new int[100];
        int[] apare = new int[100];

        Console.WriteLine("introduceti marimea vectorilor: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            Console.WriteLine("introduceti elemente primului vectorului: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("introduceti marimea vectorilor: ");
        m = Convert.ToInt32(Console.ReadLine());


        for (j = 0; j < m; j++)
        {
            Console.WriteLine("introduceti elemente celui de al doilea vector: ");
            vector2[j] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            x = 0;
            for (j = 0; j < m; j++)
            {
                if (vector[i] == vector2[j])
                {
                    x++;
                }
            }

            if (x > 0)
            {
                vector3[k] = vector[i];
                k++;
            }
        }

        for (i = 0; i < k; i++)
        {
            apare[i] = -1;

        }


        for (i = 0; i < k; i++)
        {

            for (j = i + 1; j < k; j++)
            {
                z = 1;
                if (vector3[i] == vector3[k])
                {
                    apare[j] = 0;
                    z++;

                }
                if (apare[i] != 0)
                {
                    apare[i] = z;
                }
            }
        }

        for (i = 0; i < k; i++)
        {
            if (apare[i] != 0)
            {
                Console.WriteLine("elementele comune sunt: {0}", vector3[i]);
            }
        }




    }

        private static void Array2NewArr()
        {
            int i, j = 0, n;

            Console.WriteLine("introduceti marimea vectorului: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]=", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            for ( i = 0; i < n; i++)
            {
                b[j] = a[i];
                j++;
            }

            Console.WriteLine("Vectorul nou: ");
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("b[{0}]={1}", i, b[i]);

            }


        }


        private static void DeleteDupl()
        {
            int i, j, n, z = 0;
            Console.WriteLine("introduceti marimea vect: ");
            n = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>(n);
            //List<int> b = new List<int>(1000);   
            int[] b = new int[n];

            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]=", i);
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for ( i = 0; i < a.Count; i++)
            {
                for ( j = i+1; j < a.Count; j++)
                {
                    if(a[i]==a[j])
                    {
                        b[z] = j;
                        z++;
                    }

                }
                

            }

            for ( i = b.Length; i >= 0; i++)
            {
                a.RemoveAt(b[i]);

            }
            Console.WriteLine("vectorul fara dubluri este: ");
            for ( i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);

            }

        }







}
}
