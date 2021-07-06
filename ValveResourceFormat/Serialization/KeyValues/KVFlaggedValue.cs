// <auto-generated/>
// Make stylecop ignore this file because we're rewriting KV3 in separate project.
using System;

namespace ValveResourceFormat.Serialization.KeyValues
{
    public enum KVFlag
    {
        None = 0,
        Resource = 1,
        ResourceName = 2,
        Panorama = 8,
        SoundEvent = 16,
        SubClass = 32,
    }

    public class KVFlaggedValue : KVValue
    {
        public KVFlag Flag { get; private set; }

        public KVFlaggedValue(KVType type, object value)
            : base(type, value)
        {
            Flag = KVFlag.None;
        }

        public KVFlaggedValue(KVType type, KVFlag flag, object value)
            : base(type, value)
        {
            Flag = flag;
        }
    }
}