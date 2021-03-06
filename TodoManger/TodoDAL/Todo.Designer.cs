﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Todo", "TaskGroupTask", "TaskGroup", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(TodoDAL.TaskGroup), "Task", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TodoDAL.Task), true)]
[assembly: EdmRelationshipAttribute("Todo", "clientTask", "client", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(TodoDAL.client), "Task", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(TodoDAL.Task), true)]

#endregion

namespace TodoDAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TodoContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TodoContainer object using the connection string found in the 'TodoContainer' section of the application configuration file.
        /// </summary>
        public TodoContainer() : base("name=TodoContainer", "TodoContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TodoContainer object.
        /// </summary>
        public TodoContainer(string connectionString) : base(connectionString, "TodoContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TodoContainer object.
        /// </summary>
        public TodoContainer(EntityConnection connection) : base(connection, "TodoContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Task> Tasks
        {
            get
            {
                if ((_Tasks == null))
                {
                    _Tasks = base.CreateObjectSet<Task>("Tasks");
                }
                return _Tasks;
            }
        }
        private ObjectSet<Task> _Tasks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TaskGroup> TaskGroups
        {
            get
            {
                if ((_TaskGroups == null))
                {
                    _TaskGroups = base.CreateObjectSet<TaskGroup>("TaskGroups");
                }
                return _TaskGroups;
            }
        }
        private ObjectSet<TaskGroup> _TaskGroups;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<client> clients
        {
            get
            {
                if ((_clients == null))
                {
                    _clients = base.CreateObjectSet<client>("clients");
                }
                return _clients;
            }
        }
        private ObjectSet<client> _clients;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tasks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTasks(Task task)
        {
            base.AddObject("Tasks", task);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TaskGroups EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTaskGroups(TaskGroup taskGroup)
        {
            base.AddObject("TaskGroups", taskGroup);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the clients EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToclients(client client)
        {
            base.AddObject("clients", client);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Todo", Name="client")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class client : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new client object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="pic">Initial value of the pic property.</param>
        public static client Createclient(global::System.Int32 id, global::System.String name, global::System.String pic)
        {
            client client = new client();
            client.Id = id;
            client.name = name;
            client.pic = pic;
            return client;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String pic
        {
            get
            {
                return _pic;
            }
            set
            {
                OnpicChanging(value);
                ReportPropertyChanging("pic");
                _pic = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("pic");
                OnpicChanged();
            }
        }
        private global::System.String _pic;
        partial void OnpicChanging(global::System.String value);
        partial void OnpicChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Todo", "clientTask", "Task")]
        public EntityCollection<Task> Tasks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Task>("Todo.clientTask", "Task");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Task>("Todo.clientTask", "Task", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Todo", Name="Task")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Task : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Task object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="details">Initial value of the details property.</param>
        /// <param name="taskGroupId">Initial value of the TaskGroupId property.</param>
        /// <param name="clientId">Initial value of the clientId property.</param>
        /// <param name="datePosted">Initial value of the DatePosted property.</param>
        public static Task CreateTask(global::System.Int32 id, global::System.String details, global::System.Int32 taskGroupId, global::System.Int32 clientId, global::System.DateTime datePosted)
        {
            Task task = new Task();
            task.Id = id;
            task.details = details;
            task.TaskGroupId = taskGroupId;
            task.clientId = clientId;
            task.DatePosted = datePosted;
            return task;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String details
        {
            get
            {
                return _details;
            }
            set
            {
                OndetailsChanging(value);
                ReportPropertyChanging("details");
                _details = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("details");
                OndetailsChanged();
            }
        }
        private global::System.String _details;
        partial void OndetailsChanging(global::System.String value);
        partial void OndetailsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TaskGroupId
        {
            get
            {
                return _TaskGroupId;
            }
            set
            {
                OnTaskGroupIdChanging(value);
                ReportPropertyChanging("TaskGroupId");
                _TaskGroupId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TaskGroupId");
                OnTaskGroupIdChanged();
            }
        }
        private global::System.Int32 _TaskGroupId;
        partial void OnTaskGroupIdChanging(global::System.Int32 value);
        partial void OnTaskGroupIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 clientId
        {
            get
            {
                return _clientId;
            }
            set
            {
                OnclientIdChanging(value);
                ReportPropertyChanging("clientId");
                _clientId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("clientId");
                OnclientIdChanged();
            }
        }
        private global::System.Int32 _clientId;
        partial void OnclientIdChanging(global::System.Int32 value);
        partial void OnclientIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DatePosted
        {
            get
            {
                return _DatePosted;
            }
            set
            {
                OnDatePostedChanging(value);
                ReportPropertyChanging("DatePosted");
                _DatePosted = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DatePosted");
                OnDatePostedChanged();
            }
        }
        private global::System.DateTime _DatePosted;
        partial void OnDatePostedChanging(global::System.DateTime value);
        partial void OnDatePostedChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Todo", "TaskGroupTask", "TaskGroup")]
        public TaskGroup TaskGroup
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TaskGroup>("Todo.TaskGroupTask", "TaskGroup").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TaskGroup>("Todo.TaskGroupTask", "TaskGroup").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TaskGroup> TaskGroupReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TaskGroup>("Todo.TaskGroupTask", "TaskGroup");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TaskGroup>("Todo.TaskGroupTask", "TaskGroup", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Todo", "clientTask", "client")]
        public client client
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<client>("Todo.clientTask", "client").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<client>("Todo.clientTask", "client").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<client> clientReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<client>("Todo.clientTask", "client");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<client>("Todo.clientTask", "client", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Todo", Name="TaskGroup")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TaskGroup : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TaskGroup object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="datePosted">Initial value of the DatePosted property.</param>
        public static TaskGroup CreateTaskGroup(global::System.Int32 id, global::System.String name, global::System.DateTime datePosted)
        {
            TaskGroup taskGroup = new TaskGroup();
            taskGroup.Id = id;
            taskGroup.Name = name;
            taskGroup.DatePosted = datePosted;
            return taskGroup;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DatePosted
        {
            get
            {
                return _DatePosted;
            }
            set
            {
                OnDatePostedChanging(value);
                ReportPropertyChanging("DatePosted");
                _DatePosted = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DatePosted");
                OnDatePostedChanged();
            }
        }
        private global::System.DateTime _DatePosted;
        partial void OnDatePostedChanging(global::System.DateTime value);
        partial void OnDatePostedChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Todo", "TaskGroupTask", "Task")]
        public EntityCollection<Task> Tasks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Task>("Todo.TaskGroupTask", "Task");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Task>("Todo.TaskGroupTask", "Task", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
