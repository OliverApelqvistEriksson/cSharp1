using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024
{
    public class Hund
    {
        public int ben { get; set; }
        private string päls;

        public void setPäls(string p)
        {
            this.päls = p;
        }
        public string getPäls()
        {
            return this.päls;
        }
    }

    public class franchise
    {
        private string FranchiseName;
        private string FranchiseGenre;
    }
    public class karakters:franchise
    {
        public int age { get; set; }
        private string CharacterName;
        private string description;
        public string gender;
        private bool alive { get; set; }
    }
    public class main_character:karakters
    {
        private bool plot_armour;
        private int teammates;


        
        public void setTeam(int t)
        {
            teammates = t;
        }
        public int getTeam()
        {
            return teammates;
        }
        public main_character() {
            Console.WriteLine("Main character was not filled");
        }
        public main_character(string FranchiseName, string FranchiseGenre, string CharacterName, int age, string description, string gender, bool alive, bool plot_armour, int teammates)
        {
            FranchiseName = FranchiseName;
            FranchiseGenre = FranchiseGenre;
            CharacterName = CharacterName;
            description = description;
            gender = gender;
            alive = alive;
            plot_armour = plot_armour;
            teammates = teammates;
            age = age;
            Console.WriteLine("MC setup complete");
        }
    }
}
