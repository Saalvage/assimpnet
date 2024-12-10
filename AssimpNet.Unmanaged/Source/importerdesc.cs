// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required

namespace AssimpNet.Unmanaged
{
    /// <summary>
    /// <para>Mixed set of flags for #aiImporterDesc, indicating some features</para>
    /// <para>common to many importers</para>
    /// </summary>
    [Flags]
    public enum ImporterFlags
    {
        /// <summary>
        /// <para>Indicates that there is a textual encoding of the</para>
        /// <para>file format; and that it is supported.</para>
        /// </summary>
        SupportTextFlavour = 1,
        /// <summary>
        /// <para>Indicates that there is a binary encoding of the</para>
        /// <para>file format; and that it is supported.</para>
        /// </summary>
        SupportBinaryFlavour = 2,
        /// <summary>
        /// <para>Indicates that there is a compressed encoding of the</para>
        /// <para>file format; and that it is supported.</para>
        /// </summary>
        SupportCompressedFlavour = 4,
        /// <summary>
        /// <para>Indicates that the importer reads only a very particular</para>
        /// <para>subset of the file format. This happens commonly for</para>
        /// <para>declarative or procedural formats which cannot easily</para>
        /// <para>be mapped to #aiScene</para>
        /// </summary>
        LimitedSupport = 8,
        /// <summary>
        /// <para>Indicates that the importer is highly experimental and</para>
        /// <para>should be used with care. This only happens for trunk</para>
        /// <para>(i.e. SVN) versions, experimental code is not included</para>
        /// <para>in releases.</para>
        /// </summary>
        Experimental = 16
    }

    /// <summary>
    /// <para>Meta information about a particular importer. Importers need to fill</para>
    /// <para>this structure, but they can freely decide how talkative they are.</para>
    /// <para>A common use case for loader meta info is a user interface</para>
    /// <para>in which the user can choose between various import/export file</para>
    /// <para>formats. Building such an UI by hand means a lot of maintenance</para>
    /// <para>as importers/exporters are added to Assimp, so it might be useful</para>
    /// <para>to have a common mechanism to query some rough importer</para>
    /// <para>characteristics.</para>
    /// </summary>
    public unsafe partial class ImporterDesc : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 64)]
        public partial struct __Internal
        {
            internal __IntPtr mName;
            internal __IntPtr mAuthor;
            internal __IntPtr mMaintainer;
            internal __IntPtr mComments;
            internal uint mFlags;
            internal uint mMinMajor;
            internal uint mMinMinor;
            internal uint mMaxMajor;
            internal uint mMaxMinor;
            internal __IntPtr mFileExtensions;
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AssimpNet.Unmanaged.ImporterDesc> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AssimpNet.Unmanaged.ImporterDesc>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::AssimpNet.Unmanaged.ImporterDesc managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::AssimpNet.Unmanaged.ImporterDesc managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        private bool __mName_OwnsNativeMemory = false;
        private bool __mAuthor_OwnsNativeMemory = false;
        private bool __mMaintainer_OwnsNativeMemory = false;
        private bool __mComments_OwnsNativeMemory = false;
        private bool __mFileExtensions_OwnsNativeMemory = false;
        protected bool __ownsNativeInstance;

        internal static ImporterDesc __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new ImporterDesc(native.ToPointer(), skipVTables);
        }

        internal static ImporterDesc __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (ImporterDesc)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static ImporterDesc __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new ImporterDesc(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private ImporterDesc(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected ImporterDesc(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__mName_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->mName);
            if (__mAuthor_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->mAuthor);
            if (__mMaintainer_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->mMaintainer);
            if (__mComments_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->mComments);
            if (__mFileExtensions_OwnsNativeMemory)
                Marshal.FreeHGlobal(((__Internal*)__Instance)->mFileExtensions);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Full name of the importer (i.e. Blender3D importer)</summary>
        public string MName
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->mName);
            }

            set
            {
                if (__mName_OwnsNativeMemory)
                    Marshal.FreeHGlobal(((__Internal*)__Instance)->mName);
                __mName_OwnsNativeMemory = true;
                if (value == null)
                {
                    ((__Internal*)__Instance)->mName = global::System.IntPtr.Zero;
                    return;
                }
                var __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
                Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
                Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
                ((__Internal*)__Instance)->mName = (__IntPtr) __bytePtr0;
            }
        }

        /// <summary>Original author (left blank if unknown or whole assimp team)</summary>
        public string MAuthor
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->mAuthor);
            }

            set
            {
                if (__mAuthor_OwnsNativeMemory)
                    Marshal.FreeHGlobal(((__Internal*)__Instance)->mAuthor);
                __mAuthor_OwnsNativeMemory = true;
                if (value == null)
                {
                    ((__Internal*)__Instance)->mAuthor = global::System.IntPtr.Zero;
                    return;
                }
                var __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
                Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
                Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
                ((__Internal*)__Instance)->mAuthor = (__IntPtr) __bytePtr0;
            }
        }

        /// <summary>Current maintainer, left blank if the author maintains</summary>
        public string MMaintainer
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->mMaintainer);
            }

            set
            {
                if (__mMaintainer_OwnsNativeMemory)
                    Marshal.FreeHGlobal(((__Internal*)__Instance)->mMaintainer);
                __mMaintainer_OwnsNativeMemory = true;
                if (value == null)
                {
                    ((__Internal*)__Instance)->mMaintainer = global::System.IntPtr.Zero;
                    return;
                }
                var __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
                Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
                Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
                ((__Internal*)__Instance)->mMaintainer = (__IntPtr) __bytePtr0;
            }
        }

        /// <summary>Implementation comments, i.e. unimplemented features</summary>
        public string MComments
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->mComments);
            }

            set
            {
                if (__mComments_OwnsNativeMemory)
                    Marshal.FreeHGlobal(((__Internal*)__Instance)->mComments);
                __mComments_OwnsNativeMemory = true;
                if (value == null)
                {
                    ((__Internal*)__Instance)->mComments = global::System.IntPtr.Zero;
                    return;
                }
                var __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
                Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
                Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
                ((__Internal*)__Instance)->mComments = (__IntPtr) __bytePtr0;
            }
        }

        /// <summary>
        /// <para>These flags indicate some characteristics common to many</para>
        /// <para>importers.</para>
        /// </summary>
        public uint MFlags
        {
            get
            {
                return ((__Internal*)__Instance)->mFlags;
            }

            set
            {
                ((__Internal*)__Instance)->mFlags = value;
            }
        }

        /// <summary>
        /// <para>Minimum format version that can be loaded im major.minor format,</para>
        /// <para>both are set to 0 if there is either no version scheme</para>
        /// <para>or if the loader doesn't care.</para>
        /// </summary>
        public uint MMinMajor
        {
            get
            {
                return ((__Internal*)__Instance)->mMinMajor;
            }

            set
            {
                ((__Internal*)__Instance)->mMinMajor = value;
            }
        }

        public uint MMinMinor
        {
            get
            {
                return ((__Internal*)__Instance)->mMinMinor;
            }

            set
            {
                ((__Internal*)__Instance)->mMinMinor = value;
            }
        }

        /// <summary>
        /// <para>Maximum format version that can be loaded im major.minor format,</para>
        /// <para>both are set to 0 if there is either no version scheme</para>
        /// <para>or if the loader doesn't care. Loaders that expect to be</para>
        /// <para>forward-compatible to potential future format versions should</para>
        /// <para>indicate  zero, otherwise they should specify the current</para>
        /// <para>maximum version.</para>
        /// </summary>
        public uint MMaxMajor
        {
            get
            {
                return ((__Internal*)__Instance)->mMaxMajor;
            }

            set
            {
                ((__Internal*)__Instance)->mMaxMajor = value;
            }
        }

        public uint MMaxMinor
        {
            get
            {
                return ((__Internal*)__Instance)->mMaxMinor;
            }

            set
            {
                ((__Internal*)__Instance)->mMaxMinor = value;
            }
        }

        /// <summary>
        /// <para>List of file extensions this importer can handle.</para>
        /// <para>List entries are separated by space characters.</para>
        /// <para>All entries are lower case without a leading dot (i.e.</para>
        /// <para>&quot;xml dae&quot; would be a valid value. Note that multiple</para>
        /// <para>importers may respond to the same file extension -</para>
        /// <para>assimp calls all importers in the order in which they</para>
        /// <para>are registered and each importer gets the opportunity</para>
        /// <para>to load the file until one importer &quot;claims&quot; the file. Apart</para>
        /// <para>from file extension checks, importers typically use</para>
        /// <para>other methods to quickly reject files (i.e. magic</para>
        /// <para>words) so this does not mean that common or generic</para>
        /// <para>file extensions such as XML would be tediously slow.</para>
        /// </summary>
        public string MFileExtensions
        {
            get
            {
                return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ((__Internal*)__Instance)->mFileExtensions);
            }

            set
            {
                if (__mFileExtensions_OwnsNativeMemory)
                    Marshal.FreeHGlobal(((__Internal*)__Instance)->mFileExtensions);
                __mFileExtensions_OwnsNativeMemory = true;
                if (value == null)
                {
                    ((__Internal*)__Instance)->mFileExtensions = global::System.IntPtr.Zero;
                    return;
                }
                var __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                var __bytePtr0 = Marshal.AllocHGlobal(__bytes0.Length + 1);
                Marshal.Copy(__bytes0, 0, __bytePtr0, __bytes0.Length);
                Marshal.WriteByte(__bytePtr0 + __bytes0.Length, 0);
                ((__Internal*)__Instance)->mFileExtensions = (__IntPtr) __bytePtr0;
            }
        }
    }

    public unsafe partial class importerdesc
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("assimp", EntryPoint = "aiGetImporterDesc", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetImporterDesc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string extension);
        }

        /// <summary>Returns the Importer description for a given extension.</summary>
        /// <param name="extension">[in] The extension to look for</param>
        /// <returns>A pointer showing to the ImporterDesc,</returns>
        /// <remarks>
        /// <para>Will return a nullptr if no assigned importer desc. was found for the given extension</para>
        /// <para>aiImporterDesc.</para>
        /// </remarks>
        public static global::AssimpNet.Unmanaged.ImporterDesc GetImporterDesc(string extension)
        {
            var ___ret = __Internal.GetImporterDesc(extension);
            var __result0 = global::AssimpNet.Unmanaged.ImporterDesc.__GetOrCreateInstance(___ret, false);
            return __result0;
        }
    }
}
