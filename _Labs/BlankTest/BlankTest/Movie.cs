using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Lab10

{



    class Movie

    {

        private String title;

        private String category;

        public Movie(string title, string category)
        {

            this.title = title;

            //How do I ensure only animated, drama, horror, or scifi get put here?

            this.category = category;

        }

        public string getTitle()

        {

            return title;

        }

        public string getCategory()

        {

            return category;

        }

    }

}