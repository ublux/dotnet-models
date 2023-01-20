This are the Models used by Zapier and Integromat when they send events. 

For example when a call terminates we cannot send the json of CallIncomingToCallFlowLogic.
We cannot send that object because it has a lot of dynamic content. Instead we need a hardcoded 
Version where users can map properties. So instead we use the class EventIncomingCallTerminated