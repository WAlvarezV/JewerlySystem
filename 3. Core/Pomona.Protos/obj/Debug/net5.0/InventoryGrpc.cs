// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Inventory.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Pomona.Protos {
  public static partial class InventorySrv
  {
    static readonly string __ServiceName = "Pomona.InventorySrv";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Pomona.Protos.ItemProto> __Marshaller_Pomona_ItemProto = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Pomona.Protos.ItemProto.Parser));
    static readonly grpc::Marshaller<global::Pomona.Protos.ItemResponse> __Marshaller_Pomona_ItemResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Pomona.Protos.ItemResponse.Parser));

    static readonly grpc::Method<global::Pomona.Protos.ItemProto, global::Pomona.Protos.ItemResponse> __Method_RegisterItem = new grpc::Method<global::Pomona.Protos.ItemProto, global::Pomona.Protos.ItemResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterItem",
        __Marshaller_Pomona_ItemProto,
        __Marshaller_Pomona_ItemResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Pomona.Protos.InventoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of InventorySrv</summary>
    [grpc::BindServiceMethod(typeof(InventorySrv), "BindService")]
    public abstract partial class InventorySrvBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Pomona.Protos.ItemResponse> RegisterItem(global::Pomona.Protos.ItemProto request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for InventorySrv</summary>
    public partial class InventorySrvClient : grpc::ClientBase<InventorySrvClient>
    {
      /// <summary>Creates a new client for InventorySrv</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public InventorySrvClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for InventorySrv that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public InventorySrvClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected InventorySrvClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected InventorySrvClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Pomona.Protos.ItemResponse RegisterItem(global::Pomona.Protos.ItemProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterItem(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pomona.Protos.ItemResponse RegisterItem(global::Pomona.Protos.ItemProto request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegisterItem, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.ItemResponse> RegisterItemAsync(global::Pomona.Protos.ItemProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterItemAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.ItemResponse> RegisterItemAsync(global::Pomona.Protos.ItemProto request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegisterItem, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override InventorySrvClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new InventorySrvClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(InventorySrvBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterItem, serviceImpl.RegisterItem).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, InventorySrvBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pomona.Protos.ItemProto, global::Pomona.Protos.ItemResponse>(serviceImpl.RegisterItem));
    }

  }
}
#endregion
