using SevenBusinessClient.NetWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenBusinessClient.Services
{
    public class ArticleService
    {
        SevenBusinessClient.NetWork.ArticleNetwork NetWork { get; set; }
        public ArticleService(SevenBusinessClient.NetWork.ArticleNetwork network) {
        
            NetWork = network;
        }

        public void GetAllArticle(SevenBusinessClient.NetWork.GetAllArticleEventHandler GetAllArticle){ 
        
           NetWork.GetAllArticleCompleted += GetAllArticle;
           NetWork.GetAllArticles();
        }

        public void ddd()
        {
            this.GetAllArticle(GetAllArticleCompleted);
        }

       
    }
}
