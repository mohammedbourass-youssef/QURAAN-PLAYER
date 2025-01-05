using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.CoreAudioApi;
namespace QURAAN_PLAYER
{
    // FREE and OPEN Source
    public class clsSong
    {
        static private IWavePlayer _wavePlayer;
        static private AudioFileReader _audioFileReader;
        static public void Play(string filePath,TimeSpan current)
        {
            try
            {
                if (_audioFileReader == null || _audioFileReader.FileName != filePath)
                {
                    // Dispose of existing resources
                    Stop();
 
                    // Initialize the new file and player
                    _audioFileReader = new AudioFileReader(filePath);
                    _wavePlayer = new WaveOutEvent();
                    _wavePlayer.Init(_audioFileReader);
                }

                // Set playback position
                if (current >= TimeSpan.Zero && current <= _audioFileReader.TotalTime)
                {
                    _audioFileReader.CurrentTime = current;
                }
                else
                {
                    _audioFileReader.CurrentTime = TimeSpan.Zero; // Default to the beginning
                }

                // Start playback
                _wavePlayer.Play();
            }
            catch (Exception ex)
            {

            }
        }

        static public void Play(string filePath)
        {
            TimeSpan current = TimeSpan.Zero;
            try
            {
                if (_audioFileReader == null || _audioFileReader.FileName != filePath)
                {
                    // Dispose of existing resources
                    Stop();
                    // Initialize the new file and player
                    _audioFileReader = new AudioFileReader(filePath);
                    _wavePlayer = new WaveOutEvent();
                    _wavePlayer.Init(_audioFileReader);
                }

                // Set playback position
                if (current >= TimeSpan.Zero && current <= _audioFileReader.TotalTime)
                {
                    _audioFileReader.CurrentTime = current;
                }
                else
                {
                    _audioFileReader.CurrentTime = TimeSpan.Zero; // Default to the beginning
                }

                // Start playback
                _wavePlayer.Play();
            }
            catch (Exception ex)
            {
                
            }
        }
       static public void Stop()
       {
            try
            {
                _wavePlayer?.Stop();
                _wavePlayer?.Dispose();
                _audioFileReader?.Dispose();

                _wavePlayer = null;
                _audioFileReader = null;
            }
            catch (Exception ex)
            {
                
            }
       }
       static public TimeSpan GetCurrentLength()
       {
             return _audioFileReader?.CurrentTime ?? TimeSpan.Zero;
       }

        static public TimeSpan GetTotalMax()
        {
            return _audioFileReader.TotalTime;
        }
       
    }
}
