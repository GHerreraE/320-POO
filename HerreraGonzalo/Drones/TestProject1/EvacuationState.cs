namespace TestProject1
{
    internal class EvacuationState
    {
        internal static EvacuationState? Evacuating;

        public static EvacuationState? Free { get; internal set; }
    }
}