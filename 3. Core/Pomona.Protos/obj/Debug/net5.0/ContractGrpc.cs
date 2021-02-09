// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Pomona.Protos.Contract {
  public static partial class ContractSrv
  {
    static readonly string __ServiceName = "Pomona.ContractSrv";

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

    static readonly grpc::Marshaller<global::Pomona.Protos.Contract.ContractProto> __Marshaller_Pomona_ContractProto = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Pomona.Protos.Contract.ContractProto.Parser));
    static readonly grpc::Marshaller<global::Pomona.Protos.Contract.ContractResponse> __Marshaller_Pomona_ContractResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Pomona.Protos.Contract.ContractResponse.Parser));
    static readonly grpc::Marshaller<global::Pomona.Protos.Contract.PaymentProto> __Marshaller_Pomona_PaymentProto = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Pomona.Protos.Contract.PaymentProto.Parser));
    static readonly grpc::Marshaller<global::Pomona.Protos.Common.IdProto> __Marshaller_Pomona_IdProto = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Pomona.Protos.Common.IdProto.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::Pomona.Protos.Contract.ContractsResponse> __Marshaller_Pomona_ContractsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Pomona.Protos.Contract.ContractsResponse.Parser));

    static readonly grpc::Method<global::Pomona.Protos.Contract.ContractProto, global::Pomona.Protos.Contract.ContractResponse> __Method_RegisterContract = new grpc::Method<global::Pomona.Protos.Contract.ContractProto, global::Pomona.Protos.Contract.ContractResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterContract",
        __Marshaller_Pomona_ContractProto,
        __Marshaller_Pomona_ContractResponse);

    static readonly grpc::Method<global::Pomona.Protos.Contract.PaymentProto, global::Pomona.Protos.Contract.ContractResponse> __Method_RegisterPayment = new grpc::Method<global::Pomona.Protos.Contract.PaymentProto, global::Pomona.Protos.Contract.ContractResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterPayment",
        __Marshaller_Pomona_PaymentProto,
        __Marshaller_Pomona_ContractResponse);

    static readonly grpc::Method<global::Pomona.Protos.Common.IdProto, global::Pomona.Protos.Contract.ContractResponse> __Method_GetContractById = new grpc::Method<global::Pomona.Protos.Common.IdProto, global::Pomona.Protos.Contract.ContractResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetContractById",
        __Marshaller_Pomona_IdProto,
        __Marshaller_Pomona_ContractResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Pomona.Protos.Contract.ContractsResponse> __Method_GetContracts = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Pomona.Protos.Contract.ContractsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetContracts",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Pomona_ContractsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Pomona.Protos.Contract.ContractReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ContractSrv</summary>
    [grpc::BindServiceMethod(typeof(ContractSrv), "BindService")]
    public abstract partial class ContractSrvBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Pomona.Protos.Contract.ContractResponse> RegisterContract(global::Pomona.Protos.Contract.ContractProto request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Pomona.Protos.Contract.ContractResponse> RegisterPayment(global::Pomona.Protos.Contract.PaymentProto request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Pomona.Protos.Contract.ContractResponse> GetContractById(global::Pomona.Protos.Common.IdProto request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Pomona.Protos.Contract.ContractsResponse> GetContracts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ContractSrv</summary>
    public partial class ContractSrvClient : grpc::ClientBase<ContractSrvClient>
    {
      /// <summary>Creates a new client for ContractSrv</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ContractSrvClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ContractSrv that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ContractSrvClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ContractSrvClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ContractSrvClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Pomona.Protos.Contract.ContractResponse RegisterContract(global::Pomona.Protos.Contract.ContractProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterContract(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pomona.Protos.Contract.ContractResponse RegisterContract(global::Pomona.Protos.Contract.ContractProto request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegisterContract, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractResponse> RegisterContractAsync(global::Pomona.Protos.Contract.ContractProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterContractAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractResponse> RegisterContractAsync(global::Pomona.Protos.Contract.ContractProto request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegisterContract, null, options, request);
      }
      public virtual global::Pomona.Protos.Contract.ContractResponse RegisterPayment(global::Pomona.Protos.Contract.PaymentProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterPayment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pomona.Protos.Contract.ContractResponse RegisterPayment(global::Pomona.Protos.Contract.PaymentProto request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegisterPayment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractResponse> RegisterPaymentAsync(global::Pomona.Protos.Contract.PaymentProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterPaymentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractResponse> RegisterPaymentAsync(global::Pomona.Protos.Contract.PaymentProto request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegisterPayment, null, options, request);
      }
      public virtual global::Pomona.Protos.Contract.ContractResponse GetContractById(global::Pomona.Protos.Common.IdProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContractById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pomona.Protos.Contract.ContractResponse GetContractById(global::Pomona.Protos.Common.IdProto request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetContractById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractResponse> GetContractByIdAsync(global::Pomona.Protos.Common.IdProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContractByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractResponse> GetContractByIdAsync(global::Pomona.Protos.Common.IdProto request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetContractById, null, options, request);
      }
      public virtual global::Pomona.Protos.Contract.ContractsResponse GetContracts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContracts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pomona.Protos.Contract.ContractsResponse GetContracts(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetContracts, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractsResponse> GetContractsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetContractsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pomona.Protos.Contract.ContractsResponse> GetContractsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetContracts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ContractSrvClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ContractSrvClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ContractSrvBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterContract, serviceImpl.RegisterContract)
          .AddMethod(__Method_RegisterPayment, serviceImpl.RegisterPayment)
          .AddMethod(__Method_GetContractById, serviceImpl.GetContractById)
          .AddMethod(__Method_GetContracts, serviceImpl.GetContracts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ContractSrvBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterContract, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pomona.Protos.Contract.ContractProto, global::Pomona.Protos.Contract.ContractResponse>(serviceImpl.RegisterContract));
      serviceBinder.AddMethod(__Method_RegisterPayment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pomona.Protos.Contract.PaymentProto, global::Pomona.Protos.Contract.ContractResponse>(serviceImpl.RegisterPayment));
      serviceBinder.AddMethod(__Method_GetContractById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pomona.Protos.Common.IdProto, global::Pomona.Protos.Contract.ContractResponse>(serviceImpl.GetContractById));
      serviceBinder.AddMethod(__Method_GetContracts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Pomona.Protos.Contract.ContractsResponse>(serviceImpl.GetContracts));
    }

  }
}
#endregion
