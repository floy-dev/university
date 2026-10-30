namespace lab2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        btnRailEncrypt.Click += (_, _) => TransformRail(encrypt: true);
        btnRailDecrypt.Click += (_, _) => TransformRail(encrypt: false);
        btnKeyPermutationEncrypt.Click += (_, _) => TransformKeyPermutation(encrypt: true);
        btnKeyPermutationDecrypt.Click += (_, _) => TransformKeyPermutation(encrypt: false);
        btnCombinedPermutationEncrypt.Click += (_, _) => TransformCombinedPermutation(encrypt: true);
        btnCombinedPermutationDecrypt.Click += (_, _) => TransformCombinedPermutation(encrypt: false);
        btnMultiplePermutationEncrypt.Click += (_, _) => TransformMultiplePermutation(encrypt: true);
        btnMultiplePermutationDecrypt.Click += (_, _) => TransformMultiplePermutation(encrypt: false);
        btnMultiplePermutationOpenInput.Click += (_, _) => OpenMultiplePermutationInput();
        btnCryptanalysisStart.Click += (_, _) => StartCryptanalysis();
        btnCryptanalysisOpenReference.Click += (_, _) => OpenCryptanalysisReference();
    }
    
    private void TransformRail(bool encrypt)
    {
        try
        {
            string textToCipher = txtRailInput.Text;
            int railStep = decimal.ToInt32(nudRailCount.Value);
            
            txtRailResult.Text = RailCipher.Transform(textToCipher, railStep, encrypt);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    
    private void TransformKeyPermutation(bool encrypt)
    {
        try
        {
            string textToCipher = txtKeyPermutationInput.Text;
            string permutationKey = txtKeyPermutationKey.Text;
            
            txtKeyPermutationResult.Text = PermutationCipher.Transform(textToCipher, permutationKey, encrypt);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void TransformCombinedPermutation(bool encrypt)
    {
        try
        {
            string text = txtCombinedPermutationInput.Text;
            string permutationKey = txtCombinedPermutationKey.Text;

            txtCombinedPermutationResult.Text = CombinedPermutationCipher.Transform(text, permutationKey, encrypt);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void TransformMultiplePermutation(bool encrypt)
    {
        try
        {
            string text = txtMultiplePermutationInput.Text;
            string permutationKey = txtMultiplePermutationKey.Text;
            int applicationCount = decimal.ToInt32(nudMultiplePermutationCount.Value);

            txtMultiplePermutationResult.Text =
                MultiplePermutationCipher.Transform(text, permutationKey, applicationCount, encrypt);
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void OpenMultiplePermutationInput()
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
        };

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                txtMultiplePermutationInputPath.Text = dialog.FileName;
                txtMultiplePermutationInput.Text = File.ReadAllText(dialog.FileName);
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message, "Не удалось открыть файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private void StartCryptanalysis()
    {
        try
        {
            string ciphertext = txtCryptanalysisCiphertext.Text;
            string referenceText = txtCryptanalysisReference.Text;
            int keyLength = decimal.ToInt32(nudCryptanalysisKeyLength.Value);

            txtCryptanalysisCandidateKey.Clear();
            txtCryptanalysisDistance.Clear();
            txtCryptanalysisPreview.Clear();

            var result = PermutationCryptanalysis.FindBestKey(
                ciphertext,
                referenceText,
                keyLength
            );
            
            txtCryptanalysisCandidateKey.Text = result.Key;
            txtCryptanalysisDistance.Text = result.Distance.ToString("F6");
            txtCryptanalysisPreview.Text = result.Plaintext;
        }
        catch (ArgumentException exception)
        {
            MessageBox.Show(exception.Message, "Некорректные параметры", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void OpenCryptanalysisReference()
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            txtCryptanalysisReference.Text = File.ReadAllText(dialog.FileName);
        }
        catch (IOException exception)
        {
            MessageBox.Show(exception.Message, "Не удалось открыть файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
