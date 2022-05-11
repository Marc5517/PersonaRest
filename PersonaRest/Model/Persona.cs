using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonaRest.Model
{
    public class Persona
    {
        private int _personaId;
        private string _name;
        private int _level;
        private string _arcana;
        private int _arcanaNo;

        public Persona()
        {

        }

        public Persona(int personaId, string name, int level, string arcana, int arcanaNo)
        {
            _personaId = personaId;
            _name = name;
            _level = level;
            _arcana = arcana;
            _arcanaNo = arcanaNo;
        }

        public int PersonaId
        {
            get => _personaId;
            set
            {
                _personaId = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                _level = value;
            }
        }

        public string Arcana
        {
            get => _arcana;
            set
            {
                _arcana = value;
            }
        }

        public int ArcanaNo
        {
            get => _arcanaNo;
            set
            {
                _arcanaNo = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(PersonaId)}: {_personaId}, {nameof(Name)}: {_name}, {nameof(Level)}: {_level}, {nameof(Arcana)}: {_arcana}, {nameof(ArcanaNo)}: {_arcanaNo}";
        }
    }
}
