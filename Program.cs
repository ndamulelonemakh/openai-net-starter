using OpenAI.Chat;

ChatClient client = new(model: "gpt-4o", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"));
// ChatCompletion completion = client.CompleteChat("Say 'this is a test.'");
// Console.WriteLine($"[ASSISTANT]: {completion.Content[0].Text}");

// While loop
// wait for user message
// Once received print user message to the console
// If user types in the words exit, break out of the loop

string? userInput;
List<ChatMessage> chatHistory = new List<ChatMessage>();
while (true)
{
    Console.WriteLine("Enter your message:");
    userInput = Console.ReadLine();
    if(userInput?.ToLower() == "exit") break;

    // Add user message to keep context between multiple turns
    chatHistory.Add(new UserChatMessage(userInput));

    Console.WriteLine("\n------------------------");
    Console.WriteLine($"\n[USER]: {userInput}");
    ChatCompletion chatCompletion = client.CompleteChat(chatHistory);
    Console.WriteLine($"\n[ASSISTANT]: {chatCompletion.Content[0].Text}");
    Console.WriteLine("------------------------\n");

    // also keep track of the assistant response so it knows what it said previously
    chatHistory.Add(new AssistantChatMessage(chatCompletion.Content[0].Text));
}