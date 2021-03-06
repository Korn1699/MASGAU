﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MASGAU.Registry;
using MVC;
namespace MASGAU {
    public class StartupHelper: ANotifyingObject {

        RegistryHandler reg;
        private string name, program;
        public StartupHelper(string name, string program) {
            this.name = name;
            this.program = program;
            reg = new RegistryHandler("current_user", @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        }

        public bool IsEnabled {
            get {
                return reg.getValue(name) != null;
            }
            set {
                if (value) {
                    if(!reg.setValue(name, program))
                        throw new Translator.TranslateableException("AutoStartEnableError");
                } else {
                    if (reg.getValue(name) != null) {
                        reg.deleteValue(name);
                    }
                }
                NotifyPropertyChanged("IsEnabled");
            }
        }
    }
}
