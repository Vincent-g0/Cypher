using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cypher
{
    public partial class Coder : Form
    {
        char cbuff1;
        int ibuff1, ibuff2 = 0;
        string output_prev = "", sbuff1, sbuff2, sbuff3;
        
        string[,] CSR_eng_alph = { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }, { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" } };
        string[,] CSR_rus_alph = { { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" }, { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" } };
        // vigenere
        char[,] VZN_eng_alph = {{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'},
                                 {'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a'},
                                {'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b'},
                                {'d', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c'},
                                {'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd'},
                                {'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e'},
                                {'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f'},
                                {'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g'},
                                {'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'},
                                {'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i'},
                                {'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'},
                                {'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k'},
                                {'m', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l'},
                                {'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm'},
                                {'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n'},
                                {'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o'},
                                {'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p'},
                                {'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q'},
                                {'s', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r'},
                                {'t', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's'},
                                {'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't'},
                                {'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u'},
                                {'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v'},
                                {'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w'},
                                {'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x'},
                                {'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y'}};

        char[,] VZN_rus_alph = {{ 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я',},
                                { 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а',},
                                { 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б'},
                                { 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в'},
                                { 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г'},
                                { 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д'},
                                { 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е'},
                                { 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё'},
                                { 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж'},
                                { 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з'},
                                { 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и'},
                                { 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й'},
                                { 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к'},
                                { 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л'},
                                { 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м'},
                                { 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н'},
                                { 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о'},
                                { 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п'},
                                { 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р'},
                                { 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с'},
                                { 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п'},
                                { 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у'},
                                { 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф'},
                                { 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х'},
                                { 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц'},
                                { 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч'},
                                { 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш'},
                                { 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'},
                                { 'ы', 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ'},
                                { 'ь', 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы'},
                                { 'э', 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь'},
                                { 'ю', 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э'},
                                { 'я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'п', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю'}};

        int x, y = 0, i = 0;
        string pass, key, modkey, modpass;

        public Coder()
        {
            InitializeComponent();

        }

        private void Coder_Load(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex >= 1)
                quick_code.Enabled = true;
            else quick_code.Enabled = false;
        }
        private void Exit_button(object sender, EventArgs e)
        {
            Close();
        }

        private void Coder_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm f = new StartForm();
            f.Show();
        }

        private void enc_button_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Atbash_rus();
                Atbash_eng();
                output_rtb.Text = output_prev;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Caesar_rus();
                Caesar_eng();
                output_rtb.Text = output_prev;
            }
            else
            {
                if (vzn_textBox1.Text != "")
                {
                    Vigenere_eng();
                    Vigenere_rus();
                    output_rtb.Text = output_prev;
                }
                else
                    MessageBox.Show("An error was occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        //caesar
        private void csr_texBox_TextChanged(object sender, EventArgs e)
        {
            if (quick_code.Checked)
            {
                Caesar_rus();
                Caesar_eng();
                output_rtb.Text = output_prev;
            }
            else
            {
                Caesar_rus();
                Caesar_eng();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vzn_textBox1.Text != "")
            {
                Clipboard.SetText(vzn_textBox1.Text);
                button1.Text = "Copied";
                button1.BackColor = Color.LimeGreen;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, output_rtb.Text);
            MessageBox.Show("Output was successfully saved", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void copy_code_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(output_rtb.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (quick_code.Checked) enc_button.Enabled = false;
            else enc_button.Enabled = true;
        }

        private void csr_trackBar_Scroll(object sender, EventArgs e)
        {
            if (quick_code.Checked)
            {
                output_rtb.Text = "";
                csr_texBox.Text = csr_trackBar.Value.ToString();
                Caesar_rus();
                Caesar_eng();
                output_rtb.Text = output_prev;
            }
            else
            {
                csr_texBox.Text = csr_trackBar.Value.ToString();
                Caesar_rus();
                Caesar_eng();
            }
        }
        void Caesar_rus()
        {
            if (rus_radioButton.Checked)
            {
                output_prev = "";
                for (int i = 0; i < input_rtb.Text.Length; i++)
                {
                    sbuff1 = input_rtb.Text[i].ToString();
                    if (sbuff1 == sbuff1.ToUpper()) sbuff2 = "U";
                    switch (sbuff1.ToLower())
                    {
                        case "а":
                            ibuff1 = 1;
                            break;
                        case "б":
                            ibuff1 = 2;
                            break;
                        case "в":
                            ibuff1 = 3;
                            break;
                        case "г":
                            ibuff1 = 4;
                            break;
                        case "д":
                            ibuff1 = 5;
                            break;
                        case "е":
                            ibuff1 = 6;
                            break;
                        case "ё":
                            ibuff1 = 7;
                            break;
                        case "ж":
                            ibuff1 = 8;
                            break;
                        case "з":
                            ibuff1 = 9;
                            break;
                        case "и":
                            ibuff1 = 10;
                            break;
                        case "й":
                            ibuff1 = 11;
                            break;
                        case "к":
                            ibuff1 = 12;
                            break;
                        case "л":
                            ibuff1 = 13;
                            break;
                        case "м":
                            ibuff1 = 14;
                            break;
                        case "н":
                            ibuff1 = 15;
                            break;
                        case "о":
                            ibuff1 = 16;
                            break;
                        case "п":
                            ibuff1 = 17;
                            break;
                        case "р":
                            ibuff1 = 18;
                            break;
                        case "с":
                            ibuff1 = 19;
                            break;
                        case "т":
                            ibuff1 = 20;
                            break;
                        case "у":
                            ibuff1 = 21;
                            break;
                        case "ф":
                            ibuff1 = 22;
                            break;
                        case "х":
                            ibuff1 = 23;
                            break;
                        case "ц":
                            ibuff1 = 24;
                            break;
                        case "ч":
                            ibuff1 = 25;
                            break;
                        case "ш":
                            ibuff1 = 26;
                            break;
                        case "щ":
                            ibuff1 = 27;
                            break;
                        case "ъ":
                            ibuff1 = 28;
                            break;
                        case "ы":
                            ibuff1 = 29;
                            break;
                        case "ь":
                            ibuff1 = 30;
                            break;
                        case "э":
                            ibuff1 = 31;
                            break;
                        case "ю":
                            ibuff1 = 32;
                            break;
                        case "я":
                            ibuff1 = 33;
                            break;
                        default:
                            ibuff2 = 1;
                            break;

                    }
                    try
                    {
                        ibuff1 += int.Parse(csr_texBox.Text);
                    }
                    catch (Exception) { ibuff1 = 0; }
                    for (int j = ibuff1; j <= 0; j += 33) ibuff1 += 33;
                    for (int j = ibuff1; j >= 34; j -= 33) ibuff1 -= 33;
                    if (ibuff2 == 0)
                        if (sbuff2 == "U")
                        {
                            output_prev += CSR_rus_alph[0, ibuff1 - 1].ToUpper();
                            sbuff2 = "";
                        }
                        else
                            output_prev += CSR_rus_alph[0, ibuff1 - 1];
                    else
                    {
                        if (sbuff2 == "U")
                        {
                            output_prev += sbuff1.ToUpper();
                            ibuff2 = 0;
                            sbuff2 = "";
                        }
                        else
                        {
                            output_prev += sbuff1;
                            ibuff2 = 0;
                        }
                    }
                }
            }
        }

        void Caesar_eng()
        {
            if (eng_radioButton.Checked)
            {
                output_prev = "";
                for (int i = 0; i < input_rtb.Text.Length; i++)
                {
                    sbuff1 = input_rtb.Text[i].ToString();
                    if (sbuff1 == sbuff1.ToUpper()) sbuff2 = "U";
                    switch (sbuff1.ToLower())
                    {
                        case "a":
                            ibuff1 = 1;
                            break;
                        case "b":
                            ibuff1 = 2;
                            break;
                        case "c":
                            ibuff1 = 3;
                            break;
                        case "d":
                            ibuff1 = 4;
                            break;
                        case "e":
                            ibuff1 = 5;
                            break;
                        case "f":
                            ibuff1 = 6;
                            break;
                        case "g":
                            ibuff1 = 7;
                            break;
                        case "h":
                            ibuff1 = 8;
                            break;
                        case "i":
                            ibuff1 = 9;
                            break;
                        case "j":
                            ibuff1 = 10;
                            break;
                        case "k":
                            ibuff1 = 11;
                            break;
                        case "l":
                            ibuff1 = 12;
                            break;
                        case "m":
                            ibuff1 = 13;
                            break;
                        case "n":
                            ibuff1 = 14;
                            break;
                        case "o":
                            ibuff1 = 15;
                            break;
                        case "p":
                            ibuff1 = 16;
                            break;
                        case "q":
                            ibuff1 = 17;
                            break;
                        case "r":
                            ibuff1 = 18;
                            break;
                        case "s":
                            ibuff1 = 19;
                            break;
                        case "t":
                            ibuff1 = 20;
                            break;
                        case "u":
                            ibuff1 = 21;
                            break;
                        case "v":
                            ibuff1 = 22;
                            break;
                        case "w":
                            ibuff1 = 23;
                            break;
                        case "x":
                            ibuff1 = 24;
                            break;
                        case "y":
                            ibuff1 = 25;
                            break;
                        case "z":
                            ibuff1 = 26;
                            break;
                        default:
                            ibuff2 = 1;
                            break;
                    }
                    try
                    {
                        ibuff1 += int.Parse(csr_texBox.Text);
                    }
                    catch (Exception) { ibuff1 = 0; }
                    for (int j = ibuff1; j <= 0; j += 26) ibuff1 += 26;
                    for (int j = ibuff1; j >= 27; j -= 26) ibuff1 -= 26;

                    if (ibuff2 == 0)
                        if (sbuff2 == "U")
                        {
                            output_prev += CSR_eng_alph[0, ibuff1 - 1].ToUpper();
                            sbuff2 = "";
                        }
                        else
                            output_prev += CSR_eng_alph[0, ibuff1 - 1];
                    else
                    {
                        if (sbuff2 == "U")
                        {
                            output_prev += sbuff1.ToUpper();
                            ibuff2 = 0;
                            sbuff2 = "";
                        }
                        else
                        {
                            output_prev += sbuff1;
                            ibuff2 = 0;
                        }
                    }
                }
            }
        }
        //atbash
        void Atbash_rus()
        {
            if (rus_radioButton.Checked)
            {
                output_prev = "";
                for (int i = 0; i < input_rtb.Text.Length; i++)
                {
                    sbuff1 = input_rtb.Text[i].ToString();
                    if (sbuff1 == sbuff1.ToUpper()) sbuff2 = "U";
                    switch (sbuff1.ToLower())
                    {
                        case "а":
                            sbuff3 = "я";
                            break;
                        case "б":
                            sbuff3 = "ю";
                            break;
                        case "в":
                            sbuff3 = "э";
                            break;
                        case "г":
                            sbuff3 = "ь";
                            break;
                        case "д":
                            sbuff3 = "ы";
                            break;
                        case "е":
                            sbuff3 = "ъ";
                            break;
                        case "ё":
                            sbuff3 = "щ";
                            break;
                        case "ж":
                            sbuff3 = "ш";
                            break;
                        case "з":
                            sbuff3 = "ч";
                            break;
                        case "и":
                            sbuff3 = "ц";
                            break;
                        case "й":
                            sbuff3 = "х";
                            break;
                        case "к":
                            sbuff3 = "ф";
                            break;
                        case "л":
                            sbuff3 = "у";
                            break;
                        case "м":
                            sbuff3 = "т";
                            break;
                        case "н":
                            sbuff3 = "с";
                            break;
                        case "о":
                            sbuff3 = "р";
                            break;
                        case "п":
                            sbuff3 = "п";
                            break;
                        case "р":
                            sbuff3 = "о";
                            break;
                        case "с":
                            sbuff3 = "н";
                            break;
                        case "т":
                            sbuff3 = "м";
                            break;
                        case "у":
                            sbuff3 = "л";
                            break;
                        case "ф":
                            sbuff3 = "к";
                            break;
                        case "х":
                            sbuff3 = "й";
                            break;
                        case "ц":
                            sbuff3 = "и";
                            break;
                        case "ч":
                            sbuff3 = "з";
                            break;
                        case "ш":
                            sbuff3 = "ж";
                            break;
                        case "щ":
                            sbuff3 = "ё";
                            break;
                        case "ъ":
                            sbuff3 = "е";
                            break;
                        case "ы":
                            sbuff3 = "д";
                            break;
                        case "ь":
                            sbuff3 = "г";
                            break;
                        case "э":
                            sbuff3 = "в";
                            break;
                        case "ю":
                            sbuff3 = "б";
                            break;
                        case "я":
                            sbuff3 = "а";
                            break;
                        default:
                            ibuff2 = 1;
                            break;
                    }
                    if (ibuff2 == 0)
                        if (sbuff2 == "U")
                        {
                            output_prev += sbuff3.ToUpper();
                            sbuff2 = "";
                        }
                        else
                            output_prev += sbuff3;
                    else
                    {
                        if (sbuff2 == "U")
                        {
                            output_prev += sbuff1.ToUpper();
                            ibuff2 = 0;
                            sbuff2 = "";
                        }
                        else
                        {
                            output_prev += sbuff1;
                            ibuff2 = 0;
                        }
                    }
                }
            }
        }

        void Atbash_eng()
        {
            if (eng_radioButton.Checked)
            {
                output_prev = "";
                for (int i = 0; i < input_rtb.Text.Length; i++)
                {
                    sbuff1 = input_rtb.Text[i].ToString();
                    
                    switch (sbuff1.ToLower())
                    {
                        case "a":
                            sbuff3 = "z";
                            break;
                        case "b":
                            sbuff3 = "y";
                            break;
                        case "c":
                            sbuff3 = "x";
                            break;
                        case "d":
                            sbuff3 = "w";
                            break;
                        case "e":
                            sbuff3 = "v";
                            break;
                        case "f":
                            sbuff3 = "u";
                            break;
                        case "g":
                            sbuff3 = "t";
                            break;
                        case "h":
                            sbuff3 = "s";
                            break;
                        case "i":
                            sbuff3 = "r";
                            break;
                        case "j":
                            sbuff3 = "q";
                            break;
                        case "k":
                            sbuff3 = "p";
                            break;
                        case "l":
                            sbuff3 = "o";
                            break;
                        case "m":
                            sbuff3 = "n";
                            break;
                        case "n":
                            sbuff3 = "m";
                            break;
                        case "o":
                            sbuff3 = "l";
                            break;
                        case "p":
                            sbuff3 = "k";
                            break;
                        case "q":
                            sbuff3 = "j";
                            break;
                        case "r":
                            sbuff3 = "i";
                            break;
                        case "s":
                            sbuff3 = "h";
                            break;
                        case "t":
                            sbuff3 = "g";
                            break;
                        case "u":
                            sbuff3 = "f";
                            break;
                        case "v":
                            sbuff3 = "e";
                            break;
                        case "w":
                            sbuff3 = "d";
                            break;
                        case "x":
                            sbuff3 = "c";
                            break;
                        case "y":
                            sbuff3 = "b";
                            break;
                        case "z":
                            sbuff3 = "a";
                            break;
                        default:
                            ibuff2 = 1;
                            break;
                    }
                    if (ibuff2 == 0)
                        if (sbuff2 == "U")
                        {
                            output_prev += sbuff3.ToUpper();
                            sbuff2 = "";
                        }
                        else
                            output_prev += sbuff3;
                    else
                    {
                        if (sbuff2 == "U")
                        {
                            output_prev += sbuff1.ToUpper();
                            ibuff2 = 0;
                            sbuff2 = "";
                        }
                        else
                        {
                            output_prev += sbuff1;
                            ibuff2 = 0;
                        }
                    }
                }
            }
        }
        //vigenere
        private void vzn_textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "Copy key";
            button1.BackColor = Color.Transparent;
            if (quick_code.Checked)
            {
                if (vzn_textBox1.Text != "")
                {
                    Vigenere_eng();
                    Vigenere_rus();
                    output_rtb.Text = output_prev;
                }
                else
                    output_rtb.Text = input_rtb.Text;
            }
        }

        void Vigenere_eng()
        {
            if (eng_radioButton.Checked)
            {
                
                key = vzn_textBox1.Text;
                pass = input_rtb.Text;

                //преобразовывает ключ

                modkey = key;
                while (pass.Length >= modkey.Length)
                {
                    modkey += modkey;
                };
                while (pass.Length != modkey.Length)
                {
                    modkey = modkey.Substring(0, modkey.Length - 1);
                };

                output_prev = "";
                modpass = "";
                while (i < pass.Length)
                {

                    if (pass[i].ToString() == pass[i].ToString().ToUpper()) sbuff2 = "U";

                    cbuff1 = pass[i];
                    cbuff1 = char.Parse(cbuff1.ToString().ToLower());
                    switch (cbuff1)
                    {
                        case 'a':
                            x = 0;
                            break;
                        case 'b':
                            x = 1;
                            break;
                        case 'c':
                            x = 2;
                            break;
                        case 'd':
                            x = 3;
                            break;
                        case 'e':
                            x = 4;
                            break;
                        case 'f':
                            x = 5;
                            break;
                        case 'g':
                            x = 6;
                            break;
                        case 'h':
                            x = 7;
                            break;
                        case 'i':
                            x = 8;
                            break;
                        case 'j':
                            x = 9;
                            break;
                        case 'k':
                            x = 10;
                            break;
                        case 'l':
                            x = 11;
                            break;
                        case 'm':
                            x = 12;
                            break;
                        case 'n':
                            x = 13;
                            break;
                        case 'o':
                            x = 14;
                            break;
                        case 'p':
                            x = 15;
                            break;
                        case 'q':
                            x = 16;
                            break;
                        case 'r':
                            x = 17;
                            break;
                        case 's':
                            x = 18;
                            break;
                        case 't':
                            x = 19;
                            break;
                        case 'u':
                            x = 20;
                            break;
                        case 'v':
                            x = 21;
                            break;
                        case 'w':
                            x = 22;
                            break;
                        case 'x':
                            x = 23;
                            break;
                        case 'y':
                            x = 24;
                            break;
                        case 'z':
                            x = 25;
                            break;
                        default:
                            ibuff2 = 1;
                            sbuff3 = cbuff1.ToString();
                            break;
                    }

                    cbuff1 = modkey[i];

                    switch (cbuff1)
                    {
                        case 'a':
                            y = 0;
                            break;
                        case 'b':
                            y = 1;
                            break;
                        case 'c':
                            y = 2;
                            break;
                        case 'd':
                            y = 3;
                            break;
                        case 'e':
                            y = 4;
                            break;
                        case 'f':
                            y = 5;
                            break;
                        case 'g':
                            y = 6;
                            break;
                        case 'h':
                            y = 7;
                            break;
                        case 'i':
                            y = 8;
                            break;
                        case 'j':
                            y = 9;
                            break;
                        case 'k':
                            y = 10;
                            break;
                        case 'l':
                            y = 11;
                            break;
                        case 'm':
                            y = 12;
                            break;
                        case 'n':
                            y = 13;
                            break;
                        case 'o':
                            y = 14;
                            break;
                        case 'p':
                            y = 15;
                            break;
                        case 'q':
                            y = 16;
                            break;
                        case 'r':
                            y = 17;
                            break;
                        case 's':
                            y = 18;
                            break;
                        case 't':
                            y = 19;
                            break;
                        case 'u':
                            y = 20;
                            break;
                        case 'v':
                            y = 21;
                            break;
                        case 'w':
                            y = 22;
                            break;
                        case 'x':
                            y = 23;
                            break;
                        case 'y':
                            y = 24;
                            break;
                        case 'z':
                            y = 25;
                            break;
                        default:
                            ibuff2 = 1;
                            break;
                    }

                    if (ibuff2 == 0)
                        if (sbuff2 == "U")
                        {
                            modpass += VZN_eng_alph[x, y].ToString().ToUpper();
                            sbuff2 = "";
                        }
                        else
                            modpass += VZN_eng_alph[x, y].ToString();
                    else
                    {
                        if (sbuff2 == "U")
                        {
                            modpass += sbuff3.ToUpper();
                            sbuff3 = "";
                            sbuff2 = "";
                        }
                        else
                            modpass += sbuff3;
                        ibuff2 = 0;
                    }
                i++;
                }   
            }
            i = 0;
            output_prev = modpass;
        }

        void Vigenere_rus()
        {
            if (rus_radioButton.Checked)
            {

                key = vzn_textBox1.Text;
                pass = input_rtb.Text;

                //преобразовывает ключ

                modkey = key;
                while (pass.Length >= modkey.Length)
                {
                    modkey += modkey;
                };
                while (pass.Length != modkey.Length)
                {
                    modkey = modkey.Substring(0, modkey.Length - 1);
                };

                output_prev = "";
                modpass = "";
                while (i < pass.Length)
                {

                    if (pass[i].ToString() == pass[i].ToString().ToUpper()) sbuff2 = "U";

                    cbuff1 = pass[i];
                    cbuff1 = char.Parse(cbuff1.ToString().ToLower());
                    switch (cbuff1)
                    {
                        case 'а':
                            x = 0;
                            break;
                        case 'б':
                            x = 1;
                            break;
                        case 'в':
                            x = 2;
                            break;
                        case 'г':
                            x = 3;
                            break;
                        case 'д':
                            x = 4;
                            break;
                        case 'е':
                            x = 5;
                            break;
                        case 'ё':
                            x = 6;
                            break;
                        case 'ж':
                            x = 7;
                            break;
                        case 'з':
                            x = 8;
                            break;
                        case 'и':
                            x = 9;
                            break;
                        case 'й':
                            x = 10;
                            break;
                        case 'к':
                            x = 11;
                            break;
                        case 'л':
                            x = 12;
                            break;
                        case 'м':
                            x = 13;
                            break;
                        case 'н':
                            x = 14;
                            break;
                        case 'о':
                            x = 15;
                            break;
                        case 'п':
                            x = 16;
                            break;
                        case 'р':
                            x = 17;
                            break;
                        case 'с':
                            x = 18;
                            break;
                        case 'т':
                            x = 19;
                            break;
                        case 'у':
                            x = 20;
                            break;
                        case 'ф':
                            x = 21;
                            break;
                        case 'х':
                            x = 22;
                            break;
                        case 'ц':
                            x = 23;
                            break;
                        case 'ч':
                            x = 24;
                            break;
                        case 'ш':
                            x = 25;
                            break;
                        case 'щ':
                            x = 26;
                            break;
                        case 'ъ':
                            x = 27;
                            break;
                        case 'ы':
                            x = 28;
                            break;
                        case 'ь':
                            x = 29;
                            break;
                        case 'э':
                            x = 30;
                            break;
                        case 'ю':
                            x = 31;
                            break;
                        case 'я':
                            x = 32;
                            break;
                        default:
                            ibuff2 = 1;
                            sbuff3 = cbuff1.ToString();
                            break;
                    }

                    cbuff1 = modkey[i];

                    switch (cbuff1)
                    {
                        case 'а':
                            y = 0;
                            break;
                        case 'б':
                            y = 1;
                            break;
                        case 'в':
                            y = 2;
                            break;
                        case 'г':
                            y = 3;
                            break;
                        case 'д':
                            y = 4;
                            break;
                        case 'е':
                            y = 5;
                            break;
                        case 'ё':
                            y = 6;
                            break;
                        case 'ж':
                            y = 7;
                            break;
                        case 'з':
                            y = 8;
                            break;
                        case 'и':
                            y = 9;
                            break;
                        case 'й':
                            y = 10;
                            break;
                        case 'к':
                            y = 11;
                            break;
                        case 'л':
                            y = 12;
                            break;
                        case 'м':
                            y = 13;
                            break;
                        case 'н':
                            y = 14;
                            break;
                        case 'о':
                            y = 15;
                            break;
                        case 'п':
                            y = 16;
                            break;
                        case 'р':
                            y = 17;
                            break;
                        case 'с':
                            y = 18;
                            break;
                        case 'т':
                            y = 19;
                            break;
                        case 'у':
                            y = 20;
                            break;
                        case 'ф':
                            y = 21;
                            break;
                        case 'х':
                            y = 22;
                            break;
                        case 'ц':
                            y = 23;
                            break;
                        case 'ч':
                            y = 24;
                            break;
                        case 'ш':
                            y = 25;
                            break;
                        case 'щ':
                            y = 26;
                            break;
                        case 'ъ':
                            y = 27;
                            break;
                        case 'ы':
                            y = 28;
                            break;
                        case 'ь':
                            y = 29;
                            break;
                        case 'э':
                            y = 30;
                            break;
                        case 'ю':
                            y = 31;
                            break;
                        case 'я':
                            y = 32;
                            break;
                        default:
                            ibuff2 = 1;
                            break;
                    }

                    if (ibuff2 == 0)
                        if (sbuff2 == "U")
                        {
                            modpass += VZN_rus_alph[x, y].ToString().ToUpper();
                            sbuff2 = "";
                        }
                        else
                            modpass += VZN_rus_alph[x, y].ToString();
                    else
                    {
                        if (sbuff2 == "U")
                        {
                            modpass += sbuff3.ToUpper();
                            sbuff3 = "";
                            sbuff2 = "";
                        }
                        else
                            modpass += sbuff3;
                        ibuff2 = 0;
                    }
                    i++;
                }
            }
            i = 0;
            output_prev = modpass;
        }
    }
}
