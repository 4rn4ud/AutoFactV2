using AutoFact2.Repository;
using AutoFact2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFact2.Views;

namespace AutoFact2.Controllers
{
    public class ProfilController
    {
        public ProfilRepository profilRepository;
        public ProfilController() 
        { 
            profilRepository = new ProfilRepository();
        }

        public List<Profil> findAll()
        {
            return profilRepository.findAll();
        }
    }
}
