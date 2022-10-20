using MediatR;

namespace YURI.APLICACION.Common.Ports
{
    public interface IInputPort<InteractorRequestType, InteractorResponseType> : IRequest
    {
        public InteractorRequestType RequestData { get; }
        public IOutputPort<InteractorResponseType> OutputPort { get; }
    }
}
