namespace DocRuTests
{
    public static class AlwaysFiveReturner
    {
        private enum EnumForMagic
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five
        }

        public static int ReturnFive()
        {
            return (int)EnumForMagic.Five;
        }

    }
}
