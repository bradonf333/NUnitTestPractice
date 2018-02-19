using System;

namespace SpecialDateStoreDemo
{
    public class SepcialDateStore
    {
        public DateTime DateOf(SpecialDates specialDate)
        {
            switch(specialDate)
            {
                case SpecialDates.NewMillennium:
                    return new DateTime(2000, 1, 1, 0, 0, 0, 0);
                case SpecialDates.NewCentury:
                    return new DateTime(2100, 1, 1, 0, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException("specialDate");
            }

        }
    }

    public enum SpecialDates
    {
        NewMillennium,
        NewCentury
    }
}
