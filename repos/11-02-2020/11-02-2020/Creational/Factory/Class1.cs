using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_2020.Creational.Factory
{
    class Class1
    {
        public interface Comic
        {
            void view();
        }
        public class Doraemon : Comic
        {
            public void view()
            {
                Console.WriteLine("Doraemon view");
            }
        }

        public class Conan : Comic
        {
            public void view()
            {
                Console.WriteLine("Conan view");
            }
        }

        public class Shinoshuke : Comic
        {
            public void view()
            {
                Console.WriteLine("Shinoshuke view");
            }
        }

        public class Users
        {
            public void viewDoraemon()
            {
                Doraemon doraemon = new Doraemon();
                doraemon.view();
            }

            public void viewConan()
            {
                Conan conan = new Conan();
                conan.view();
            }

            public void viewShinoshuke()
            {
                Shinoshuke shinoshuke = new Shinoshuke();
                shinoshuke.view();
            }
        }


        public class comicFactory
        {
            public void viewComic(string comicType)
            {
                Comic comic;
                if (comicType.Equals("Doraemon"))
                {
                    comic = new Doraemon();
                    comic.view();
                }
                else if (comicType.Equals("Conan"))
                {
                    comic = new Conan();
                    comic.view();
                }
                else if (comicType.Equals("Shinoshuke"))
                {
                    comic = new Shinoshuke();
                    comic.view();
                }
            }
        }

        public class User
        {
            public void viewComic()
            {
                comicFactory comicF = new comicFactory();
                comicF.viewComic("Doraemon");
                comicF.viewComic("Conan");
                comicF.viewComic("Shinoshuke");
            }
        }
    }
}

