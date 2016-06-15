using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBScreener.Screener
{
    public class ScreenUtil
    {
        public const string reviewUriPrefix = "http://www.amazon.com/product-reviews/";

        public int getReviewNumber(string asin)
        {
            int reviewNo = -1;
            string reviewUri = reviewUriPrefix + asin;

            return reviewNo;
        }
    }
}
