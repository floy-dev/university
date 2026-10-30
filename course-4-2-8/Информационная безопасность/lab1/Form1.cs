using System.Text;

namespace lab1;

public partial class Form1 : Form
{
    private string affineCiphertextForAnalysis = string.Empty;

    public Form1()
    {
        InitializeComponent();

        btnEncryptAffine.Click += (_, _) => TransformAffine(encrypt: true);
        btnDecryptAffine.Click += (_, _) => TransformAffine(encrypt: false);
        btnClearAffine.Click += (_, _) => ClearAffineFields();
        btnOpenAffineInput.Click += (_, _) => OpenAffineInput();
        btnSaveAffineResult.Click += (_, _) => SaveAffineResult();

        btnEncryptVigenere.Click += (_, _) => TransformVigenere(encrypt: true);
        btnDecryptVigenere.Click += (_, _) => TransformVigenere(encrypt: false);
        btnClearVigenere.Click += (_, _) => ClearVigenereFields();
        btnOpenVigenereInput.Click += (_, _) => OpenVigenereInput();
        btnSaveVigenereResult.Click += (_, _) => SaveVigenereResult();

        btnEncodeNato.Click += (_, _) => EncodeNato();
        btnDecodeNato.Click += (_, _) => DecodeNato();
        btnClearNato.Click += (_, _) => ClearNatoFields();
        btnOpenNatoInput.Click += (_, _) => OpenNatoInput();
        btnSaveNatoResult.Click += (_, _) => SaveNatoResult();

        btnEncryptRotor.Click += (_, _) => TransformRotor(encrypt: true);
        btnDecryptRotor.Click += (_, _) => TransformRotor(encrypt: false);
        btnClearRotor.Click += (_, _) => ClearRotorFields();
        btnOpenRotorInput.Click += (_, _) => OpenRotorInput();
        btnSaveRotorResult.Click += (_, _) => SaveRotorResult();

        btnLoadAffineCiphertext.Click += (_, _) => LoadAffineCiphertext();
        btnBruteForceAffine.Click += (_, _) => BruteForceAffine();
        btnFindRotorState.Click += (_, _) => FindRotorState();
        btnCalculateFrequencies.Click += (_, _) => CalculateFrequencies();
    }

    private void TransformAffine(bool encrypt)
    {
        try
        {
            int a = decimal.ToInt32(nudAffineA.Value);
            int b = decimal.ToInt32(nudAffineB.Value);
            txtAffineResult.Text = AffineCipher.Transform(txtAffineInput.Text, a, b, encrypt);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void TransformVigenere(bool encrypt)
    {
        try
        {
            txtVigenereResult.Text = VigenereCipher.Transform(
                txtVigenereInput.Text,
                txtVigenereKey.Text,
                encrypt);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректный ключ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void OpenAffineInput()
    {
        if (ofdAffineInput.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            txtAffineInput.Text = File.ReadAllText(ofdAffineInput.FileName, Encoding.UTF8);
            txtAffineInputPath.Text = ofdAffineInput.FileName;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось прочитать файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveAffineResult()
    {
        if (sfdAffineResult.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            File.WriteAllText(sfdAffineResult.FileName, txtAffineResult.Text);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось сохранить файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearAffineFields()
    {
        txtAffineInput.Clear();
        txtAffineResult.Clear();
        txtAffineInputPath.Text = "Файл не выбран";
        txtAffineInput.Focus();
    }

    private void OpenVigenereInput()
    {
        if (ofdVigenereInput.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            txtVigenereInput.Text = File.ReadAllText(ofdVigenereInput.FileName, Encoding.UTF8);
            txtVigenereInputPath.Text = ofdVigenereInput.FileName;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось прочитать файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveVigenereResult()
    {
        if (sfdVigenereResult.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            File.WriteAllText(sfdVigenereResult.FileName, txtVigenereResult.Text, new UTF8Encoding(false));
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось сохранить файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearVigenereFields()
    {
        txtVigenereInput.Clear();
        txtVigenereResult.Clear();
        txtVigenereKey.Clear();
        txtVigenereInputPath.Text = "Файл не выбран";
        txtVigenereInput.Focus();
    }

    private void EncodeNato()
    {
        txtNatoResult.Text = NatoCipher.Encode(txtNatoInput.Text);
    }

    private void DecodeNato()
    {
        try
        {
            txtNatoResult.Text = NatoCipher.Decode(txtNatoInput.Text);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректный текст НАТО", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void OpenNatoInput()
    {
        if (ofdNatoInput.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            txtNatoInput.Text = File.ReadAllText(ofdNatoInput.FileName, Encoding.UTF8);
            txtNatoInputPath.Text = ofdNatoInput.FileName;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось прочитать файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveNatoResult()
    {
        if (sfdNatoResult.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            File.WriteAllText(sfdNatoResult.FileName, txtNatoResult.Text, new UTF8Encoding(false));
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось сохранить файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearNatoFields()
    {
        txtNatoInput.Clear();
        txtNatoResult.Clear();
        txtNatoInputPath.Text = "Файл не выбран";
        txtNatoInput.Focus();
    }

    private void TransformRotor(bool encrypt)
    {
        try
        {
            txtRotorResult.Text = RotorCipher.Transform(
                txtRotorInput.Text,
                txtRotorPermutation.Text,
                decimal.ToInt32(nudRotorStartPosition.Value),
                decimal.ToInt32(nudRotorStep.Value),
                encrypt);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректные параметры ротора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void OpenRotorInput()
    {
        if (ofdRotorInput.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            txtRotorInput.Text = File.ReadAllText(ofdRotorInput.FileName, Encoding.UTF8);
            txtRotorInputPath.Text = ofdRotorInput.FileName;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось прочитать файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveRotorResult()
    {
        if (sfdRotorResult.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            File.WriteAllText(sfdRotorResult.FileName, txtRotorResult.Text, new UTF8Encoding(false));
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось сохранить файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearRotorFields()
    {
        txtRotorInput.Clear();
        txtRotorResult.Clear();
        txtRotorInputPath.Text = "Файл не выбран";
        txtRotorInput.Focus();
    }

    private void LoadAffineCiphertext()
    {
        if (ofdFrequencySource.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            affineCiphertextForAnalysis = File.ReadAllText(ofdFrequencySource.FileName, Encoding.UTF8);
            txtAffineBruteForceResult.Text = affineCiphertextForAnalysis;
            txtFrequencyAnalysisResult.Text = $"Загружен шифртекст: {ofdFrequencySource.FileName}";
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Не удалось прочитать файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BruteForceAffine()
    {
        try
        {
            txtAffineBruteForceResult.Text = AffineCryptanalysis.BruteForce(affineCiphertextForAnalysis);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Перебор ключей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void FindRotorState()
    {
        try
        {
            txtRotorAttackResult.Text = RotorCryptanalysis.FindStates(
                txtKnownPlaintext.Text,
                txtKnownCiphertext.Text,
                txtRotorPermutation.Text,
                decimal.ToInt32(nudMaxRotorShift.Value));
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Атака на роторный шифр", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void CalculateFrequencies()
    {
        try
        {
            txtFrequencyAnalysisResult.Text = FrequencyAnalysis.FormatFrequencies(affineCiphertextForAnalysis);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Частотный анализ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
