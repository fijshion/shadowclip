using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShadowClip.services
{
    public interface IEncoder
    {
        Task Encode(string originalFile, string outputFile, double start, double end, int zoom, int slowMo, bool useGpu,
            IProgress<EncodeProgress> encodeProgresss, CancellationToken cancelToken);
    }

    public class EncodeProgress
    {
        public EncodeProgress(int percentComplete, int framesPerSecond)
        {
            PercentComplete = percentComplete;
            FramesPerSecond = framesPerSecond;
        }

        public int PercentComplete { get; }
        public int FramesPerSecond { get; }
    }
}