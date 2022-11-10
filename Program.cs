using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace EVALUATION
{
    
    public class exam
    {
        int num_eval;
        float duree_eval;
        string matiere;
        DateTime duree;
        public class etudiant
        {
            string nom,prenom;
            int num;

        }   
        
        public class question
        {
            int num_quest;
            string quest ;
           
            }

        }
    public class reponce:exam
    {
        string rep;
        int num_quest;
       
    }
    public class qsm:reponce
    {
        bool validite;
        int num_quest;
        bool est_valide();
    }
    public class rep_normale:reponce
    {
        string rep;
        int point_quest;
    }
}     
    internal class Program
    {
        static void Main(string[] args)
        {



        }
    }
}
