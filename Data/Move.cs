using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalcManager.Data
{
    class Move
    {
        internal int Move_ID { get; set; }
        internal Type Type_m { get; set; }
        internal Category Category_m { get; set; }
        internal int Power { get; set; }
        internal int Accuracy { get; set; }
        internal int Priority { get; set; }
        internal bool Contact { get; set; }
        internal bool Protect { get; set; }
        internal bool HasSecondaryEffect { get; set; } // For Sheer Force boost
        internal bool HasRecoilDamage { get; set; } // For Reckless boost
        internal List<int> LearnBy; //List of Pokémon ID that learn the move

        /// <summary>
        /// Bit0: Targets ally? / Bit1: Targets Enemy? / Bit2: Targets self? / Bit3: Targets non-adjacents? / Bit4: AoE?
        /// </summary>
        internal int Target { get; set; }

        internal string Name_EN { get; set; }
        internal string Name_DE { get; set; }
        internal string Name_FR { get; set; }
        internal string Name_IT { get; set; }
        internal string Name_ES { get; set; }
        internal string Name_JP { get; set; }
        internal string Name_KR { get; set; }

        internal string Name()
        {
            switch (Properties.Settings.Default.Language)
            {
                case 2: return Name_DE;
                case 3: return Name_FR;
                case 4: return Name_IT;
                case 5: return Name_ES;
                case 6: return Name_JP;
                case 7: return Name_KR;

                default: return Name_EN;
            }

        }

        internal Move(int id, Type type, int power = 0, int accuracy = 100, Category category = Category.Physical,
            int priority = 0, bool contact = false, bool protect = false, bool hasSecondaryEffect = false, bool hasRecoil = false, int target = 2)
        {

        }
    }
}
