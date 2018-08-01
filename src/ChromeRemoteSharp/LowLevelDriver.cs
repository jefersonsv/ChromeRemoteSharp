using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp
{
    public class LowLevelDriver : RawDriver
    {
        public AccessibilityDomain.AccessibilityDomain Accessibility { get; }
        public AnimationDomain.AnimationDomain Animation { get; }
        public ApplicationCacheDomain.ApplicationCacheDomain ApplicationCache { get; }
        public AuditsDomain.AuditsDomain Audits { get; }
        public BrowserDomain.BrowserDomain Browser { get; }
        public CacheStorageDomain.CacheStorageDomain CacheStorage { get; }
        public ConsoleDomain.ConsoleDomain Console { get; }
        public CssDomain.CssDomain Css { get; }
        public DatabaseDomain.DatabaseDomain Database { get; }
        public DebuggerDomain.DebuggerDomain Debugger { get; }
        public DeviceOrientationDomain.DeviceOrientationDomain DeviceOrientation { get; }
        public DomDebuggerDomain.DomDebuggerDomain DomDebugger { get; }
        public DomDomain.DomDomain Dom { get; }
        public DomSnapshotDomain.DomSnapshotDomain DomSnapshot { get; }
        public DomStorageDomain.DomStorageDomain DomStorage { get; }
        public EmulationDomain.EmulationDomain Emulation { get; }
        public HeadlessExperimentalDomain.HeadlessExperimentalDomain HeadlessExperimental { get; }
        public HeapProfilerDomain.HeapProfilerDomain HeapProfiler { get; }
        public IndexedDBDomain.IndexedDBDomain IndexedDB { get; }
        public InputDomain.InputDomain Input { get; }
        public InspectorDomain.InspectorDomain Inspector { get; }
        public IODomain.IODomain IO { get; }
        public LayerTreeDomain.LayerTreeDomain LayerTree { get; }
        public LogDomain.LogDomain Log { get; }
        public MemoryDomain.MemoryDomain Memory { get; }
        public NetworkDomain.NetworkDomain Network { get; }
        public OverlayDomain.OverlayDomain Overlay { get; }
        public PageDomain.PageDomain Page { get; }
        public PerformanceDomain.PerformanceDomain Performance { get; }
        public ProfilerDomain.ProfilerDomain Profiler { get; }
        public RuntimeDomain.RuntimeDomain Runtime { get; }
        public SchemaDomain.SchemaDomain Schema { get; }
        public SecurityDomain.SecurityDomain Security { get; }
        public ServiceWorkerDomain.ServiceWorkerDomain ServiceWorker { get; }
        public StorageDomain.StorageDomain Storage { get; }
        public SystemInfoDomain.SystemInfoDomain SystemInfo { get; }
        public TargetDomain.TargetDomain Target { get; }
        public TetheringDomain.TetheringDomain Tethering { get; }
        public TracingDomain.TracingDomain Tracing { get; }

        public LowLevelDriver(Uri uri) : base(uri)
        {
            this.Accessibility = new AccessibilityDomain.AccessibilityDomain(this);
            this.Animation = new AnimationDomain.AnimationDomain(this);
            this.ApplicationCache = new ApplicationCacheDomain.ApplicationCacheDomain(this);
            this.Audits = new AuditsDomain.AuditsDomain(this);
            this.Browser = new BrowserDomain.BrowserDomain(this);
            this.CacheStorage = new CacheStorageDomain.CacheStorageDomain(this);
            this.Console = new ConsoleDomain.ConsoleDomain(this);
            this.Css = new CssDomain.CssDomain(this);
            this.Database = new DatabaseDomain.DatabaseDomain(this);
            this.Debugger = new DebuggerDomain.DebuggerDomain(this);
            this.DeviceOrientation = new DeviceOrientationDomain.DeviceOrientationDomain(this);
            this.Dom = new DomDomain.DomDomain(this);
            this.DomDebugger = new DomDebuggerDomain.DomDebuggerDomain(this);
            this.DomSnapshot = new DomSnapshotDomain.DomSnapshotDomain(this);
            this.DomStorage = new DomStorageDomain.DomStorageDomain(this);
            this.Emulation = new EmulationDomain.EmulationDomain(this);
            this.HeadlessExperimental = new HeadlessExperimentalDomain.HeadlessExperimentalDomain(this);
            this.HeapProfiler = new HeapProfilerDomain.HeapProfilerDomain(this);
            this.IndexedDB = new IndexedDBDomain.IndexedDBDomain(this);
            this.Input = new InputDomain.InputDomain(this);
            this.Inspector = new InspectorDomain.InspectorDomain(this);
            this.IO = new IODomain.IODomain(this);
            this.LayerTree = new LayerTreeDomain.LayerTreeDomain(this);
            this.Log = new LogDomain.LogDomain(this);
            this.Memory = new MemoryDomain.MemoryDomain(this);
            this.Network = new NetworkDomain.NetworkDomain(this);
            this.Overlay = new OverlayDomain.OverlayDomain(this);
            this.Page = new PageDomain.PageDomain(this);
            this.Performance = new PerformanceDomain.PerformanceDomain(this);
            this.Profiler = new ProfilerDomain.ProfilerDomain(this);
            this.Runtime = new RuntimeDomain.RuntimeDomain(this);
            this.Schema = new SchemaDomain.SchemaDomain(this);
            this.Security = new SecurityDomain.SecurityDomain(this);
            this.ServiceWorker = new ServiceWorkerDomain.ServiceWorkerDomain(this);
            this.Storage = new StorageDomain.StorageDomain(this);
            this.SystemInfo = new SystemInfoDomain.SystemInfoDomain(this);
            this.Target = new TargetDomain.TargetDomain(this);
            this.Tethering = new TetheringDomain.TetheringDomain(this);
            this.Tracing = new TracingDomain.TracingDomain(this);
        }
    }
}
