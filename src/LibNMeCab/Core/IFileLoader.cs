using System;
using System.IO;

namespace NMeCab.Core
{
    public abstract class IFileLoader: IDisposable
    {
        public static Type FileLoaderType = typeof(MemoryMappedFileLoader);
        public static IFileLoader NewFileLoader => (IFileLoader)Activator.CreateInstance(FileLoaderType);

        public abstract BinaryReader CreateBinaryReader(string path);

        public abstract long FileSize { get; }

        public abstract unsafe byte* Invoke(string file);

        public abstract void Dispose();
    }
}