#region #fileheader
// Sebastiano GaudeanoEsCSharpTerzoTentativoDelegatiTerzoTentativoCarDb.cs1412:37
#endregion

#region using
using UtilForDelegates;
#endregion

namespace TerzoTentativoDelegati
{
    public class TerzoTentativoCarDb : CarDb
    {

        public delegate void ProcessCarDelegate ( Car car );

        public void GiveMeCarToProcess ( ProcessCarDelegate ProcessCar )
        {
            foreach ( Car car in Cars )
            {
                ProcessCar( car );
            }
        }
    }
}