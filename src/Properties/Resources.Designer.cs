﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace processor.Properties {
    using System;
    
    
    /// <summary>
    ///   Yerelleştirilmiş dizeleri aramak gibi işlemler için, türü kesin olarak belirtilmiş kaynak sınıfı.
    /// </summary>
    // Bu sınıf ResGen veya Visual Studio gibi bir araç kullanılarak StronglyTypedResourceBuilder
    // sınıfı tarafından otomatik olarak oluşturuldu.
    // Üye eklemek veya kaldırmak için .ResX dosyanızı düzenleyin ve sonra da ResGen
    // komutunu /str seçeneğiyle yeniden çalıştırın veya VS projenizi yeniden oluşturun.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Bu sınıf tarafından kullanılan, önbelleğe alınmış ResourceManager örneğini döndürür.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("processor.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Tümü için geçerli iş parçacığının CurrentUICulture özelliğini geçersiz kular
        ///   CurrentUICulture özelliğini tüm kaynak aramaları için geçersiz kılar.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   LOAD the register R with the bit pattern found in the
        ///memory cell whose address is XY.
        ///Example: 0x14A3 would cause the contents of the memory
        ///cell located at address 0xA3 to be placed in register 0x4. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x1En {
            get {
                return ResourceManager.GetString("0x1En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   LOAD the register R with the bit pattern XY.
        ///Example: 0x20A3 would cause the value 0xA3 to be
        ///placed in register 0. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x2En {
            get {
                return ResourceManager.GetString("0x2En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   STORE the bit pattern found in register R in the memory
        ///cell whose address is XY.
        ///Example: 0x35B1 would cause the contents of register
        ///0x5 to be placed in the memory cell whose address is
        ///0xB1. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x3En {
            get {
                return ResourceManager.GetString("0x3En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   MOVE the bit pattern found in register R to register S.
        ///Example: 0x40A4 would cause the contents of register
        ///0xA to be copied into register 0x4. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x4En {
            get {
                return ResourceManager.GetString("0x4En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ADD the bit patterns in registers S and T as though they
        ///were two’s complement representations and leave the
        ///result in register R.
        ///Example: 0x5726 would cause the binary values in registers 0x2 and 0x6 to be added and the sum placed in
        ///register 0x7. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x5En {
            get {
                return ResourceManager.GetString("0x5En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ADD the bit patterns in registers S and T as though they
        ///represented values in floating-point notation and leave
        ///the floating-point result in register R.
        ///Example: 0x634E would cause the values in registers 0x4
        ///and 0xE to be added as floating-point values and the
        ///result to be placed in register 0x3. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x6En {
            get {
                return ResourceManager.GetString("0x6En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   OR the bit patterns in registers S and T and place the
        ///result in register R.
        ///Example: 0x7CB4 would cause the result of ORing the
        ///contents of registers 0xB and 0x4 to be placed in register
        ///0xC. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x7En {
            get {
                return ResourceManager.GetString("0x7En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   AND the bit patterns in registers S and T and place the
        ///result in register R.
        ///Example: 0x8045 would cause the result of ANDing the
        ///contents of registers 0x4 and 0x5 to be placed in register
        ///0x0. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x8En {
            get {
                return ResourceManager.GetString("0x8En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   XOR the bit patterns in registers S and T and place the
        ///result in register R.
        ///Example: 0x95F3 would cause the result of XORing the
        ///contents of registers 0xF and 0x3 to be placed in register
        ///0x5. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0x9En {
            get {
                return ResourceManager.GetString("0x9En", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ROTATE the bit pattern in register R one bit to the right
        ///X times. Each time, place the bit that started at the loworder end at the high-order end.
        ///Example: 0xA403 would cause the contents of register
        ///0x4 to be rotated 3 bits to the right in a circular fashion. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0xAEn {
            get {
                return ResourceManager.GetString("0xAEn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   JUMP to the instruction located in the memory cell at
        ///address XY if the bit pattern in register R is equal to the
        ///bit pattern in register number 0. Otherwise, continue
        ///with the normal sequence of execution. (The jump is
        ///implemented by copying XY into the program counter
        ///during the execute phase.)
        ///Example: 0xB43C would first compare the contents of
        ///register 0x4 with the contents of register 0x0. If the two
        ///were equal, the pattern 0x3C would be placed in the
        ///program counter so that the next instructi [dizenin kalan bölümü kesildi]&quot;; benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0xBEn {
            get {
                return ResourceManager.GetString("0xBEn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   HALT execution.
        ///Example: 0xC000 would cause program execution to
        ///stop. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        internal static string _0xCEn {
            get {
                return ResourceManager.GetString("0xCEn", resourceCulture);
            }
        }
    }
}