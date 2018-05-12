// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
    public /* unmanaged */ unsafe struct ID3D12ShaderReflectionType
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetDesc(
            [In] ID3D12ShaderReflectionType* This,
            [Out] D3D12_SHADER_TYPE_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionType* _GetMemberTypeByIndex(
            [In] ID3D12ShaderReflectionType* This,
            [In, ComAliasName("UINT")] uint Index
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionType* _GetMemberTypeByName(
            [In] ID3D12ShaderReflectionType* This,
            [In, ComAliasName("LPCSTR")] sbyte* Name
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("LPSTR")]
        public /* static */ delegate sbyte* _GetMemberTypeName(
            [In] ID3D12ShaderReflectionType* This,
            [In, ComAliasName("UINT")] uint Index
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _IsEqual(
            [In] ID3D12ShaderReflectionType* This,
            [In] ID3D12ShaderReflectionType* pType
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionType* _GetSubType(
            [In] ID3D12ShaderReflectionType* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionType* _GetBaseClass(
            [In] ID3D12ShaderReflectionType* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate uint _GetNumInterfaces(
            [In] ID3D12ShaderReflectionType* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate ID3D12ShaderReflectionType* _GetInterfaceByIndex(
            [In] ID3D12ShaderReflectionType* This,
            [In, ComAliasName("UINT")] uint uIndex
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _IsOfType(
            [In] ID3D12ShaderReflectionType* This,
            [In] ID3D12ShaderReflectionType* pType
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _ImplementsInterface(
            [In] ID3D12ShaderReflectionType* This,
            [In] ID3D12ShaderReflectionType* pBase
        );
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int GetDesc(
            [Out] D3D12_SHADER_TYPE_DESC* pDesc
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        public ID3D12ShaderReflectionType* GetMemberTypeByIndex(
            [In, ComAliasName("UINT")] uint Index
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetMemberTypeByIndex>(lpVtbl->GetMemberTypeByIndex)(
                    This,
                    Index
                );
            }
        }

        public ID3D12ShaderReflectionType* GetMemberTypeByName(
            [In, ComAliasName("LPCSTR")] sbyte* Name
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetMemberTypeByName>(lpVtbl->GetMemberTypeByName)(
                    This,
                    Name
                );
            }
        }

        [return: ComAliasName("LPSTR")]
        public sbyte* GetMemberTypeName(
            [In, ComAliasName("UINT")] uint Index
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetMemberTypeName>(lpVtbl->GetMemberTypeName)(
                    This,
                    Index
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int IsEqual(
            [In] ID3D12ShaderReflectionType* pType
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_IsEqual>(lpVtbl->IsEqual)(
                    This,
                    pType
                );
            }
        }

        public ID3D12ShaderReflectionType* GetSubType()
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetSubType>(lpVtbl->GetSubType)(
                    This
                );
            }
        }

        public ID3D12ShaderReflectionType* GetBaseClass()
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetBaseClass>(lpVtbl->GetBaseClass)(
                    This
                );
            }
        }

        public uint GetNumInterfaces()
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetNumInterfaces>(lpVtbl->GetNumInterfaces)(
                    This
                );
            }
        }

        public ID3D12ShaderReflectionType* GetInterfaceByIndex(
            [In, ComAliasName("UINT")] uint uIndex
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_GetInterfaceByIndex>(lpVtbl->GetInterfaceByIndex)(
                    This,
                    uIndex
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int IsOfType(
            [In] ID3D12ShaderReflectionType* pType
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_IsOfType>(lpVtbl->IsOfType)(
                    This,
                    pType
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int ImplementsInterface(
            [In] ID3D12ShaderReflectionType* pBase
        )
        {
            fixed (ID3D12ShaderReflectionType* This = &this)
            {
                return MarshalFunction<_ImplementsInterface>(lpVtbl->ImplementsInterface)(
                    This,
                    pBase
                );
            }
        }
        #endregion

        #region Structs
        public /* unmanaged */ struct Vtbl
        {
            #region Fields
            public IntPtr GetDesc;

            public IntPtr GetMemberTypeByIndex;

            public IntPtr GetMemberTypeByName;

            public IntPtr GetMemberTypeName;

            public IntPtr IsEqual;

            public IntPtr GetSubType;

            public IntPtr GetBaseClass;

            public IntPtr GetNumInterfaces;

            public IntPtr GetInterfaceByIndex;

            public IntPtr IsOfType;

            public IntPtr ImplementsInterface;
            #endregion
        }
        #endregion
    }
}
