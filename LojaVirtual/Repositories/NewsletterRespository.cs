
using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class NewsletterRespository : INewsletterRepository
    {
        private LojaVirtualContext _banco;
        public NewsletterRespository(LojaVirtualContext banco)
        {
            _banco = banco;
        }
        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.NewsletterEmails.Add(newsletter);
            _banco.SaveChanges ();
        }

        public IEnumerable<NewsletterEmail> ObterTodasNewsletter()
        {
            return _banco.NewsletterEmails.ToList();
        }
    }
}
