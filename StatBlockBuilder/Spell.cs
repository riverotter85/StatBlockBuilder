using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatBlockBuilder
{
    public class Spell
    {
        private string name;

        private bool somaticComponents;
        private bool verbalComponents;
        private bool materialComponents;
        private string componentsDescription;
        private bool componentsDescriptionEnabled;

        private string level;
        private string type;
        private bool ritual;

        private string rangeType;
        private int distance;
        private bool distanceEnabled;
        private string distanceUnit;
        private bool distanceUnitEnabled;

        private string castingTimeType;
        private int castingTimeNum;
        private bool castingTimeNumEnabled;
        private string castingTimeUnit;
        private bool castingTimeUnitEnabled;
        private string castingTimeComments;

        private string durationType;
        private int durationTime;
        private bool durationTimeEnabled;
        private string durationUnit;
        private bool durationUnitEnabled;

        private string description;
        private string atHigherLevels;

        public Spell()
        {
            // default constructor
        }

        public Spell(string name, bool somaticComponents, bool verbalComponents,
                bool materialComponents, string componentsDescription, bool componentsDescriptionEnabled,
                string level, string type, bool ritual, string rangeType, int distance, bool distanceEnabled,
                string distanceUnit, bool distanceUnitEnabled, string castingTimeType, int castingTimeNum,
                bool castingTimeNumEnabled, string castingTimeUnit, bool castingTimeUnitEnabled,
                string castingTimeComments, string durationType, int durationTime, bool durationTimeEnabled,
                string durationUnit, bool durationUnitEnabled, string description, string atHigherLevels)
        {
            this.name = name;

            // Components
            this.somaticComponents = somaticComponents;
            this.verbalComponents = verbalComponents;
            this.materialComponents = materialComponents;
            this.componentsDescription = componentsDescription;
            this.componentsDescriptionEnabled = componentsDescriptionEnabled;

            this.level = level;
            this.type = type;
            this.ritual = ritual;

            // Range
            this.rangeType = rangeType;
            this.distance = distance;
            this.distanceEnabled = distanceEnabled;
            this.distanceUnit = distanceUnit;
            this.distanceUnitEnabled = distanceUnitEnabled;

            // Casting Time
            this.castingTimeType = castingTimeType;
            this.castingTimeNum = castingTimeNum;
            this.castingTimeNumEnabled = castingTimeNumEnabled;
            this.castingTimeUnit = castingTimeUnit;
            this.castingTimeUnitEnabled = castingTimeUnitEnabled;
            this.castingTimeComments = castingTimeComments;

            // Duration
            this.durationType = durationType;
            this.durationTime = durationTime;
            this.durationTimeEnabled = durationTimeEnabled;
            this.durationUnit = durationUnit;
            this.durationUnitEnabled = durationUnitEnabled;

            this.description = description;
            this.atHigherLevels = atHigherLevels;
        }

        // Convert components to string value
        public string getComponents()
        {
            bool first = true;
            string components = "";
            if (somaticComponents == true)
            {
                components += "S";
                first = false;
            }
            if (verbalComponents == true)
            {
                if (first == false)
                {
                    components += ", ";
                }
                components += "V";
                first = false;
            }
            if (materialComponents == true)
            {
                if (first == false)
                {
                    components += ", ";
                }
                components += "M";
            }

            return components;
        }

        // Convert range to string value
        public string getRange()
        {
            string range = "";
            if (rangeType == "Range")
            {
                range = distance + " " + distanceUnit;
            }
            else if (rangeType == "Self" && distance != 0)
            {
                range = "Self (" + distance + " " + distanceUnit + ")";
            }
            else
            {
                range = rangeType;
            }

            return range;
        }

        // Convert casting time to string value
        public string getCastingTime()
        {
            string castingTime = "";
            if (castingTimeType == "Time")
            {
                castingTime = castingTimeNum + " " + castingTimeUnit;
            }
            else
            {
                castingTime = castingTimeType;
            }

            // Add any casting time comments specified by the user
            if (castingTimeComments != "Comments (optional)")
            {
                castingTime += ", " + castingTimeComments;
            }

            return castingTime;
        }

        // Convert duration to string value
        public string getDuration()
        {
            string duration = "";
            if (durationType == "Time")
            {
                duration = durationTime + " " + durationUnit;
            }
            else if (durationType == "Concentration")
            {
                duration = "Concentration, up to " + durationTime + " " + durationUnit;
            }
            else
            {
                duration = durationType;
            }

            return duration;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool SomaticComponents
        {
            get { return somaticComponents; }
            set { somaticComponents = value; }
        }
        public bool VerbalComponents
        {
            get { return verbalComponents; }
            set { verbalComponents = value; }
        }
        public bool MaterialComponents
        {
            get { return materialComponents; }
            set { materialComponents = value; }
        }
        public string ComponentsDescription
        {
            get { return componentsDescription; }
            set { componentsDescription = value; }
        }
        public bool ComponentsDescriptionEnabled
        {
            get { return componentsDescriptionEnabled; }
            set { componentsDescriptionEnabled = value; }
        }
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool Ritual
        {
            get { return ritual; }
            set { ritual = value; }
        }
        public string RangeType
        {
            get { return rangeType; }
            set { rangeType = value; }
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public bool DistanceEnabled
        {
            get { return distanceEnabled; }
            set { distanceEnabled = value; }
        }
        public string DistanceUnit
        {
            get { return distanceUnit; }
            set { distanceUnit = value; }
        }
        public bool DistanceUnitEnabled
        {
            get { return distanceUnitEnabled; }
            set { distanceUnitEnabled = value; }
        }
        public string CastingTimeType
        {
            get { return castingTimeType; }
            set { castingTimeType = value; }
        }
        public int CastingTimeNum
        {
            get { return castingTimeNum; }
            set { castingTimeNum = value; }
        }
        public bool CastingTimeNumEnabled
        {
            get { return castingTimeNumEnabled; }
            set { castingTimeNumEnabled = value; }
        }
        public string CastingTimeUnit
        {
            get { return castingTimeUnit; }
            set { castingTimeUnit = value; }
        }
        public bool CastingTimeUnitEnabled
        {
            get { return castingTimeUnitEnabled; }
            set { castingTimeUnitEnabled = value; }
        }
        public string CastingTimeComments
        {
            get { return castingTimeComments; }
            set { castingTimeComments = value; }
        }
        public string DurationType
        {
            get { return durationType; }
            set { durationType = value; }
        }
        public int DurationTime
        {
            get { return durationTime; }
            set { durationTime = value; }
        }
        public bool DurationTimeEnabled
        {
            get { return durationTimeEnabled; }
            set { durationTimeEnabled = value; }
        }
        public string DurationUnit
        {
            get { return durationUnit; }
            set { durationUnit = value; }
        }
        public bool DurationUnitEnabled
        {
            get { return durationUnitEnabled; }
            set { durationUnitEnabled = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string AtHigherLevels
        {
            get { return atHigherLevels; }
            set { atHigherLevels = value; }
        }
    }
}
