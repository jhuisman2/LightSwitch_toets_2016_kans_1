﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Eigenaar> EigenarenUitBreda()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Eigenaar> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Eigenaar>("Eigenaars"),
                (e) => (e.Woonplaats.CompareTo("Breda") == 0));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Eigenaar> EigenarenOpInput(string Woonplaats)
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Eigenaar> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Eigenaar>("Eigenaars"),
                (e) => (e.Woonplaats.CompareTo(Woonplaats) == 0));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Dier> AlleKattenEnHonden()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Dier> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Dier>("Diers"),
                (d) => ((d.Soort.CompareTo("HO") == 0) || (d.Soort.CompareTo("KA") == 0)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Dierenarts> MeerDanTienDieren()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Dierenarts> query;
            query = this.GetQuery<global::LightSwitchApplication.Implementation.Dierenarts>("DierenartsSet");
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Dierenarts> DierenartsenBijAantalBehandelingenInput(global::System.Nullable<int> AantalBehandelingenParameter)
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Dierenarts> query;
            query = this.GetQuery<global::LightSwitchApplication.Implementation.Dierenarts>("DierenartsSet");
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Dierenarts))
            {
                return new global::LightSwitchApplication.Implementation.Dierenarts();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Dier))
            {
                return new global::LightSwitchApplication.Implementation.Dier();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Eigenaar))
            {
                return new global::LightSwitchApplication.Implementation.Eigenaar();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Behandeling))
            {
                return new global::LightSwitchApplication.Implementation.Behandeling();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Dierenarts))
            {
                return new global::LightSwitchApplication.Implementation.Dierenarts();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Dier))
            {
                return new global::LightSwitchApplication.Implementation.Dier();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Eigenaar))
            {
                return new global::LightSwitchApplication.Implementation.Eigenaar();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Behandeling))
            {
                return new global::LightSwitchApplication.Implementation.Behandeling();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Dierenarts) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Dierenarts);
            }
            if (typeof(global::LightSwitchApplication.Dier) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Dier);
            }
            if (typeof(global::LightSwitchApplication.Eigenaar) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Eigenaar);
            }
            if (typeof(global::LightSwitchApplication.Behandeling) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Behandeling);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Dierenarts :
        global::LightSwitchApplication.Dierenarts.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Dierenarts.DetailsClass.IImplementation.Behandelings
        {
            get
            {
                return this.Behandelings;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Dier :
        global::LightSwitchApplication.Dier.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Dier.DetailsClass.IImplementation.Behandelings
        {
            get
            {
                return this.Behandelings;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Dier.DetailsClass.IImplementation.Eigenaar
        {
            get
            {
                return this.Eigenaar;
            }
            set
            {
                this.Eigenaar = (global::LightSwitchApplication.Implementation.Eigenaar)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Eigenaar");
                }
            }
        }
        
        partial void OnDier_EigenaarChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Eigenaar");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Eigenaar :
        global::LightSwitchApplication.Eigenaar.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Eigenaar.DetailsClass.IImplementation.Diers
        {
            get
            {
                return this.Diers;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Behandeling :
        global::LightSwitchApplication.Behandeling.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Behandeling.DetailsClass.IImplementation.Dier
        {
            get
            {
                return this.Dier;
            }
            set
            {
                this.Dier = (global::LightSwitchApplication.Implementation.Dier)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Dier");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Behandeling.DetailsClass.IImplementation.Dierenarts
        {
            get
            {
                return this.Dierenarts;
            }
            set
            {
                this.Dierenarts = (global::LightSwitchApplication.Implementation.Dierenarts)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Dierenarts");
                }
            }
        }
        
        partial void OnBehandeling_DierChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Dier");
            }
        }
        
        partial void OnBehandeling_DierenartsChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Dierenarts");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

