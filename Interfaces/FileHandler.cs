/// <sumary>
/// Ein Interface ist ein Vertrag.
/// 
/// Wer ein Interface implementiert muss alle Member (Eigenschaften und Methoden)
/// des interfaces implementieren.
/// Mann könnte auch sagen ein Interface ist eine Blaupause für eine Klasse / Struct
/// welche beschreibt welche Methode/Eigenschaften 
/// diese haben müssen, aber nicht wie diese sein müssen
/// <sumary>

namespace Interfaces;

public interface IFileHandler
{
  public string FilePath { get; set; }

  public void DeleteFile();
}
 