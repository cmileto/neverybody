using System;
using Server;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Items;

namespace Server.Engines.VvV
{
    public class VvVEpaulette : Epaulette
	{
        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        public VvVEpaulette()
        {
            IsVvVItem = true;

            Attributes.AttackChance = 5;
        }

        public VvVEpaulette(Serial serial)
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

    public class VvVGargishEpaulette : GargishEpaulette
    {
        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        public VvVGargishEpaulette()
        {
            IsVvVItem = true;

            Attributes.AttackChance = 5;
        }

        public VvVGargishEpaulette(Serial serial)
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