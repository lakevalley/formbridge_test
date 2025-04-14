namespace server;

public record EmailRequest(
  string To,
  string Subject,
  string Body
);