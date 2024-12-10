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
    /// <summary>An axis-aligned bounding box.</summary>
    public unsafe partial class AABB : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 24)]
        public partial struct __Internal
        {
            internal global::System.Numerics.Vector3 mMin;
            internal global::System.Numerics.Vector3 mMax;
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AssimpNet.Unmanaged.AABB> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AssimpNet.Unmanaged.AABB>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::AssimpNet.Unmanaged.AABB managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::AssimpNet.Unmanaged.AABB managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static AABB __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new AABB(native.ToPointer(), skipVTables);
        }

        internal static AABB __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (AABB)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static AABB __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new AABB(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private AABB(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected AABB(void* native, bool skipVTables = false)
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
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::System.Numerics.Vector3 MMin
        {
            get
            {
                return ((__Internal*)__Instance)->mMin;
            }

            set
            {
                ((__Internal*)__Instance)->mMin = value;
            }
        }

        public global::System.Numerics.Vector3 MMax
        {
            get
            {
                return ((__Internal*)__Instance)->mMax;
            }

            set
            {
                ((__Internal*)__Instance)->mMax = value;
            }
        }
    }
}
