// Console.WriteLine($"Имя компьютера: {Environment.MachineName}");
// Console.WriteLine($"Пользователь: {Environment.UserName}");
// Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");
// Console.WriteLine($"OC: {Environment.OSVersion}");
// Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");
// Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
// Console.WriteLine($"PID процесса: {Environment.ProcessId}");
// long memory = Environment.WorkingSet / 1024 / 1024;
// Console.WriteLine($"Память процесса: {memory} МБ");
// Console.ReadLine();
using System.Diagnostics;

Process currentProcess = Process.GetCurrentProcess();

Console.WriteLine($"Имя процесса: {currentProcess.ProcessName}");
Console.WriteLine($"PID: {currentProcess.Id}");

for (int i = 1; i <= 3; i++)
{
    currentProcess.Refresh();
    long memoryMB = currentProcess.WorkingSet64 / 1024 / 1024;
    Console.WriteLine($"Измерение {i}: память процесса = {memoryMB} МБ");

    if (i < 3)
    {
        Console.WriteLine("Обновите окно через несколько секунд...");
        Console.ReadLine();
    }
}