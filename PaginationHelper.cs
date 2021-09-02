using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class PaginationHelper<T>   
    {
        public StringBuilder content = new StringBuilder();
        IList<T> book;
        int itemPerPage;
        public PaginationHelper(List<T> book, int itemPerPage)
        {
            this.book = book;
            this.itemPerPage = itemPerPage;
            InitializeBookContents();
        }


        private void InitializeBookContents()
        {
            int num = 0;

            foreach (var item in book)
            {
                if (num == itemPerPage)
                {
                    content.Append($"-{item}*");
                    num = 1;
                }
                else
                {
                    content.Append($"{item}*");
                    num++;
                }

            }

            content.Append('-');
        }


        public int PageItemCount(int index)
        {
            var items = content.ToString().TrimEnd('-').Split('-');
            try
            {
                return items[index].Count(c => c == '*');
            }
            catch (IndexOutOfRangeException)
            {
                return -1;
            }
        }


        public int PageIndex(int index)
        {

            index++;
            if (index > book.Count || index < 0 ) return -1;
            else return index > itemPerPage ? (index / itemPerPage) : 0;

          
        }

        public int ItemCount
        {
            get { return book.Count(); }
        }


        public int PageCount
        {
          get { return content.ToString().Count(c => c == '-'); }
        }

        
    }


    class MainRunner
    {
        static void Main(string[] args)
        {
            var helper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);

            Console.WriteLine(helper.PageItemCount(1));
            Console.WriteLine(helper.content);
            Console.WriteLine(helper.PageIndex(5));
            Console.ReadKey();
        }
    }
}
