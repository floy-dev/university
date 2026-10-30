using System.Security.Cryptography;
using System.Text;

namespace Lab3;

public partial class MainForm : Form
{
    private byte[]? aesBlockResultBytes;
    private byte[]? paddingResultBytes;
    private byte[]? ecbResultBytes;
    private byte[]? cfbResultBytes;

    public MainForm()
    {
        InitializeComponent();

        btnAesBlockEncrypt.Click += BtnAesBlockEncrypt_Click;
        btnAesBlockDecrypt.Click += BtnAesBlockDecrypt_Click;
        btnUseAesBlockResult.Click += BtnUseAesBlockResult_Click;
        btnGenerateAesBlockKey.Click += BtnGenerateAesBlockKey_Click;
        cmbAesBlockOutputFormat.SelectedIndexChanged += CmbAesBlockOutputFormat_SelectedIndexChanged;

        btnAddPadding.Click += BtnAddPadding_Click;
        btnRemovePadding.Click += BtnRemovePadding_Click;
        btnUsePaddingResult.Click += BtnUsePaddingResult_Click;
        cmbPaddingOutputFormat.SelectedIndexChanged += CmbPaddingOutputFormat_SelectedIndexChanged;

        btnEcbEncrypt.Click += BtnEcbEncrypt_Click;
        btnEcbDecrypt.Click += BtnEcbDecrypt_Click;
        btnUseEcbResult.Click += BtnUseEcbResult_Click;
        btnGenerateEcbKey.Click += BtnGenerateEcbKey_Click;
        btnOpenEcbInput.Click += BtnOpenEcbInput_Click;
        btnSaveEcbResult.Click += BtnSaveEcbResult_Click;
        cmbEcbOutputFormat.SelectedIndexChanged += CmbEcbOutputFormat_SelectedIndexChanged;

        btnCfbEncrypt.Click += BtnCfbEncrypt_Click;
        btnCfbDecrypt.Click += BtnCfbDecrypt_Click;
        btnUseCfbResult.Click += BtnUseCfbResult_Click;
        btnGenerateCfbKey.Click += BtnGenerateCfbKey_Click;
        btnGenerateCfbVector.Click += BtnGenerateCfbVector_Click;
        btnOpenCfbInput.Click += BtnOpenCfbInput_Click;
        btnSaveCfbResult.Click += BtnSaveCfbResult_Click;
        cmbCfbOutputFormat.SelectedIndexChanged += CmbCfbOutputFormat_SelectedIndexChanged;
    }

    private void BtnAesBlockEncrypt_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtAesBlockInput.Text, IsHex(cmbAesBlockInputFormat));
            byte[] key = ReadBytes(txtAesBlockKey.Text, IsHex(cmbAesBlockKeyFormat));
            aesBlockResultBytes = AesCipher.EncryptBlock(input, key);
            ShowResult(aesBlockResultBytes, txtAesBlockResult, cmbAesBlockOutputFormat);
        });
    }

    private void BtnAesBlockDecrypt_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtAesBlockInput.Text, IsHex(cmbAesBlockInputFormat));
            byte[] key = ReadBytes(txtAesBlockKey.Text, IsHex(cmbAesBlockKeyFormat));
            aesBlockResultBytes = AesCipher.DecryptBlock(input, key);
            ShowResult(aesBlockResultBytes, txtAesBlockResult, cmbAesBlockOutputFormat);
        });
    }

    private void BtnUseAesBlockResult_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => UseResult(aesBlockResultBytes, txtAesBlockInput, cmbAesBlockInputFormat));
    }

    private void BtnGenerateAesBlockKey_Click(object? sender, EventArgs eventArgs)
    {
        GenerateRandomValue(txtAesBlockKey, cmbAesBlockKeyFormat);
    }

    private void CmbAesBlockOutputFormat_SelectedIndexChanged(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => ShowResult(aesBlockResultBytes, txtAesBlockResult, cmbAesBlockOutputFormat));
    }

    private void BtnAddPadding_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtPaddingInput.Text, IsHex(cmbPaddingInputFormat));
            paddingResultBytes = Iso7816Padding.Add(input);
            ShowResult(paddingResultBytes, txtPaddingResult, cmbPaddingOutputFormat);
        });
    }

    private void BtnRemovePadding_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtPaddingInput.Text, IsHex(cmbPaddingInputFormat));
            paddingResultBytes = Iso7816Padding.Remove(input);
            ShowResult(paddingResultBytes, txtPaddingResult, cmbPaddingOutputFormat);
        });
    }

    private void BtnUsePaddingResult_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => UseResult(paddingResultBytes, txtPaddingInput, cmbPaddingInputFormat));
    }

    private void CmbPaddingOutputFormat_SelectedIndexChanged(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => ShowResult(paddingResultBytes, txtPaddingResult, cmbPaddingOutputFormat));
    }

    private void BtnEcbEncrypt_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtEcbInput.Text, IsHex(cmbEcbInputFormat));
            byte[] key = ReadBytes(txtEcbKey.Text, IsHex(cmbEcbKeyFormat));
            ecbResultBytes = EcbCipher.Encrypt(input, key);
            ShowResult(ecbResultBytes, txtEcbResult, cmbEcbOutputFormat);
        });
    }

    private void BtnEcbDecrypt_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtEcbInput.Text, IsHex(cmbEcbInputFormat));
            byte[] key = ReadBytes(txtEcbKey.Text, IsHex(cmbEcbKeyFormat));
            ecbResultBytes = EcbCipher.Decrypt(input, key);
            ShowResult(ecbResultBytes, txtEcbResult, cmbEcbOutputFormat);
        });
    }

    private void BtnUseEcbResult_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => UseResult(ecbResultBytes, txtEcbInput, cmbEcbInputFormat));
    }

    private void BtnGenerateEcbKey_Click(object? sender, EventArgs eventArgs)
    {
        GenerateRandomValue(txtEcbKey, cmbEcbKeyFormat);
    }

    private void BtnOpenEcbInput_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => OpenInputFile(txtEcbInput, cmbEcbInputFormat, txtEcbInputPath));
    }

    private void BtnSaveEcbResult_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => SaveResult(ecbResultBytes));
    }

    private void CmbEcbOutputFormat_SelectedIndexChanged(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => ShowResult(ecbResultBytes, txtEcbResult, cmbEcbOutputFormat));
    }

    private void BtnCfbEncrypt_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtCfbInput.Text, IsHex(cmbCfbInputFormat));
            byte[] key = ReadBytes(txtCfbKey.Text, IsHex(cmbCfbKeyFormat));
            byte[] vector = ReadBytes(txtCfbInitializationVector.Text, IsHex(cmbCfbVectorFormat));
            cfbResultBytes = CfbCipher.Encrypt(input, key, vector);
            ShowResult(cfbResultBytes, txtCfbResult, cmbCfbOutputFormat);
        });
    }

    private void BtnCfbDecrypt_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() =>
        {
            byte[] input = ReadBytes(txtCfbInput.Text, IsHex(cmbCfbInputFormat));
            byte[] key = ReadBytes(txtCfbKey.Text, IsHex(cmbCfbKeyFormat));
            byte[] vector = ReadBytes(txtCfbInitializationVector.Text, IsHex(cmbCfbVectorFormat));
            cfbResultBytes = CfbCipher.Decrypt(input, key, vector);
            ShowResult(cfbResultBytes, txtCfbResult, cmbCfbOutputFormat);
        });
    }

    private void BtnUseCfbResult_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => UseResult(cfbResultBytes, txtCfbInput, cmbCfbInputFormat));
    }

    private void BtnGenerateCfbKey_Click(object? sender, EventArgs eventArgs)
    {
        GenerateRandomValue(txtCfbKey, cmbCfbKeyFormat);
    }

    private void BtnGenerateCfbVector_Click(object? sender, EventArgs eventArgs)
    {
        GenerateRandomValue(txtCfbInitializationVector, cmbCfbVectorFormat);
    }

    private void BtnOpenCfbInput_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => OpenInputFile(txtCfbInput, cmbCfbInputFormat, txtCfbInputPath));
    }

    private void BtnSaveCfbResult_Click(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => SaveResult(cfbResultBytes));
    }

    private void CmbCfbOutputFormat_SelectedIndexChanged(object? sender, EventArgs eventArgs)
    {
        RunSafely(() => ShowResult(cfbResultBytes, txtCfbResult, cmbCfbOutputFormat));
    }

    private static byte[] ReadBytes(string text, bool hex)
    {
        if (!hex)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        string hexadecimalText = string.Concat(text.Where(character => !char.IsWhiteSpace(character)));

        if (hexadecimalText.Length % 2 != 0)
        {
            throw new ArgumentException("HEX-строка должна содержать чётное количество символов.");
        }

        try
        {
            return Convert.FromHexString(hexadecimalText);
        }
        catch (FormatException)
        {
            throw new ArgumentException("HEX-строка может содержать только цифры 0–9 и буквы A–F.");
        }
    }

    private static string FormatBytes(byte[] data, bool hex)
    {
        return hex
            ? Convert.ToHexString(data)
            : new UTF8Encoding(false, true).GetString(data);
    }

    private static bool IsHex(ComboBox formatComboBox)
    {
        return formatComboBox.SelectedIndex == 1;
    }

    private static void ShowResult(byte[]? data, TextBox outputTextBox, ComboBox outputFormatComboBox)
    {
        if (data == null)
        {
            return;
        }

        outputTextBox.Text = FormatBytes(data, IsHex(outputFormatComboBox));
    }

    private static void UseResult(byte[]? data, TextBox inputTextBox, ComboBox inputFormatComboBox)
    {
        if (data == null)
        {
            throw new ArgumentException("Сначала выполните операцию.");
        }

        inputFormatComboBox.SelectedIndex = 1;
        inputTextBox.Text = Convert.ToHexString(data);
    }

    private void OpenInputFile(TextBox inputTextBox, ComboBox inputFormatComboBox, TextBox pathTextBox)
    {
        using OpenFileDialog dialog = new();

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        byte[] fileBytes = File.ReadAllBytes(dialog.FileName);
        inputFormatComboBox.SelectedIndex = 1;
        inputTextBox.Text = Convert.ToHexString(fileBytes);
        pathTextBox.Text = dialog.FileName;
    }

    private void SaveResult(byte[]? data)
    {
        if (data == null)
        {
            throw new ArgumentException("Нет результата для сохранения.");
        }

        using SaveFileDialog dialog = new()
        {
            FileName = "result.bin",
            Filter = "Двоичные файлы (*.bin)|*.bin|Все файлы (*.*)|*.*"
        };

        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
            File.WriteAllBytes(dialog.FileName, data);
        }
    }

    private static void GenerateRandomValue(TextBox valueTextBox, ComboBox formatComboBox)
    {
        valueTextBox.Text = Convert.ToHexString(RandomNumberGenerator.GetBytes(AesCipher.KeySize));
        formatComboBox.SelectedIndex = 1;
    }

    private void RunSafely(Action action)
    {
        try
        {
            action();
        }
        catch (Exception exception)
        {
            MessageBox.Show(
                this,
                exception.Message,
                "Проверьте данные",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
