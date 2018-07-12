using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class FournisseurArticle
    {
        public int FournisseurArticleId { get; set; }
        public int ArticleId { get; set; }
        public int FichetiersIdfournisseur { get; set; }
        public string FournisseurArticleReference { get; set; }
        public decimal FournisseurArticlePrixAchatTC { get; set; }
        public string FournisseurArticleDeviseAchat { get; set; }
        public decimal FournisseurArticlePrixAchatDevise { get; set; }
        public decimal FournisseurArticlePrixVenteTC { get; set; }
        public string FournisseurArticleDeviseVente { get; set; }
        public string FournisseurArticlePrixVenteDevise { get; set; }

        public int FournisseurArticleSys_user { get; set; }
        public DateTime? FournisseurArticleSys_DateCreation { get; set; }
        public DateTime? FournisseurArticleSys_DateUpdate { get; set; }

        public FournisseurArticle()
        {
            FournisseurArticleSys_DateCreation = DateTime.Now;
        }

        public Fichetiers Fichetiers { get; set; }
        public Articles Articles { get; set; }



    }
}
