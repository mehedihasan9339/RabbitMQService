# RabbitMQ Documentation

## What is RabbitMQ?

RabbitMQ is an open-source message broker that implements the Advanced Message Queuing Protocol (AMQP). It provides a robust messaging system for distributing and processing messages between applications or components.

## Why do we use RabbitMQ?

RabbitMQ is used to facilitate communication between different parts of an application or between different applications. It enables asynchronous communication, decouples components, and improves scalability and reliability. It's particularly useful in distributed systems, microservices architectures, and scenarios where message processing needs to be asynchronous.

## How does RabbitMQ Work?

RabbitMQ operates as a message broker between producers and consumers. Producers send messages to named queues, and consumers receive messages from these queues. Messages can be routed based on various criteria, such as routing keys or message attributes. RabbitMQ ensures that messages are reliably delivered to consumers even in the presence of failures.

## Documentation:

### Download and Install Erlang:

- Download Erlang from [https://www.erlang.org/downloads](https://www.erlang.org/downloads) and follow the installation instructions.

### Download and Install RabbitMQ:

- Download RabbitMQ from [https://www.rabbitmq.com/docs/install-windows#installer](https://www.rabbitmq.com/docs/install-windows#installer) and follow the installation instructions.

### Verify Erlang Installation:

- Navigate to `C:\Program Files\RabbitMQ Server\rabbitmq_server-3.13.2\sbin` and run the command `erl` in the command prompt to check if Erlang is running.

### NuGet Package
- RabbitMQ.Client

### Access RabbitMQ Management Console:

- Open a web browser and go to [http://localhost:15672](http://localhost:15672).
- Log in with the default credentials:
  - Username: guest
  - Password: guest

  ![Login Screen](https://raw.githubusercontent.com/mehedihasan9339/RabbitMQService/master/loginRabbitMQ.png)

### Troubleshooting:

- If the RabbitMQ Management Console is not accessible, restart RabbitMQ from Services.

### Viewing Queues:

- After successful login, navigate to the Queue tab in the RabbitMQ Management Console to view pending and completed queues.

  ![Queue Tab](https://raw.githubusercontent.com/mehedihasan9339/RabbitMQService/master/Dashboard.png)

## Example Scenario:

In this documentation, RabbitMQService is a microservice responsible for sending messages by enqueuing them. The DemoMessaging project is the main project from which jobs are enqueued using the SendController.

This setup enables asynchronous communication between different parts of the system, improving scalability, reliability, and decoupling of components.

By following the provided steps and understanding RabbitMQ's functionality, developers can effectively utilize RabbitMQ for their messaging needs in various software architectures.


![Final](https://raw.githubusercontent.com/mehedihasan9339/RabbitMQService/master/finalResult.png)
