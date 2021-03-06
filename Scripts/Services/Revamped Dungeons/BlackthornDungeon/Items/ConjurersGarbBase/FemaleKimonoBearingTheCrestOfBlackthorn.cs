using Server;
using System;

namespace Server.Items
{
    public class FemaleKimonoBearingTheCrestOfBlackthorn7 : FemaleKimono
    {
        public override bool IsArtifact { get { return true; } }

        [Constructable]
        public FemaleKimonoBearingTheCrestOfBlackthorn7()
            : base()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            Attributes.RegenMana = 2;
            Attributes.DefendChance = 5;
            Attributes.Luck = 140;
            Hue = 1194;
        }

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        public FemaleKimonoBearingTheCrestOfBlackthorn7(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}