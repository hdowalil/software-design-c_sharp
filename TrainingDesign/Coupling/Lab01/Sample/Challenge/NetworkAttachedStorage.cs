using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling.Lab01.Sample.Challenge
{
    class NetworkAttachedStorage
    {
        private const string StarTrekVideo = "The USS Enterprise floating through the galaxy";
        private const string StarTrekAudio = "Space: the final frontier. These are the voyages of the starship Enterprise."
            + " Its five-year mission: to explore strange new worlds, to seek out new life and new civilizations,"
            + " to boldly go where no man has gone before.";

        private const string KnightRiderVideo = "David Hasselhoff in a black Pontiac Trans Am with a red light";
        private const string KnightRiderAudio = "Knight Rider, a shadowy flight into the dangerous world of a man who does not exist."
            + " Michael Knight, a young loner on a crusade to champion the cause of the innocent, the helpless,"
            + " the powerless, in a world of criminals who operate above the law.";

        public static readonly VideoAndAudio StarTrek = new VideoAndAudio(
            VideoAndAudio.ConvertStringToByteArray(StarTrekVideo),
            VideoAndAudio.ConvertStringToByteArray(StarTrekAudio));
        public static readonly VideoAndAudio KnightRider = new VideoAndAudio(
            VideoAndAudio.ConvertStringToByteArray(KnightRiderVideo),
            VideoAndAudio.ConvertStringToByteArray(KnightRiderAudio));

    }
}
