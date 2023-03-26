import re


def main():
    html_tags = ['<!DOCTYPE>', '<a>', '<abbr>', '<acronym>', '<abbr>', '<address>', '<applet>', '<embed>',
                 '<object>', '<area>', '<article>', '<aside>', '<audio>', '<b>', '<base>', '<basefont>', '<bdi>',
                 '<bdo>', '<big>', '<blockquote>', '<body>', '<br>', '<button>', '<canvas>', '<caption>', '<center>',
                 '<cite>', '<code>', '<col>', '<colgroup>', '<data>', '<datalist>', '<dd>', '<del>', '<details>',
                 '<dfn>', '<dialog>', '<dir>', '<ul>', '<div>', '<dl>', '<dt>', '<em>', '<embed>', '<fieldset>',
                 '<figcaption>', '<figure>', '<font>', '<footer>', '<form>', '<frame>', '<frameset>',
                 '<h1> to &lt;h6&gt;', '<head>', '<header>', '<hr>', '<html>', '<i>', '<iframe>', '<img>', '<input>',
                 '<ins>', '<kbd>', '<label>', '<legend>', '<li>', '<link>', '<main>', '<map>', '<mark>', '<meta>',
                 '<meter>', '<nav>', '<noframes>', '<noscript>', '<object>', '<ol>', '<optgroup>', '<option>',
                 '<output>', '<p>', '<param>', '<picture>', '<pre>', '<progress>', '<q>', '<rp>', '<rt>', '<ruby>',
                 '<s>', '<samp>', '<script>', '<section>', '<select>', '<small>', '<source>', '<span>', '<strike>',
                 '<del>', '<s>', '<strong>', '<style>', '<sub>', '<summary>', '<sup>', '<svg>', '<table>', '<tbody>',
                 '<td>', '<template>', '<textarea>', '<tfoot>', '<th>', '<thead>', '<time>', '<title>', '<tr>',
                 '<track>', '<tt>', '<u>', '<ul>', '<var>', '<video>', '<wbr>']

    n = int(input('Введите кол-во строк: '))
    strings = []
    for index in range(0, n):
        strings.append(input(f'Строчка кода #{index + 1}: '))

    concat_string = " ".join(strings)

    if is_json(concat_string):
        print('JSON')
        return

    tags = parse_tags(concat_string)
    base_tags_count = len(tags)

    intersection_of_user_tags_and_html_tags = list(set(html_tags) & set(tags))

    if len(intersection_of_user_tags_and_html_tags) / base_tags_count > 0.5:
        print('HTML')
        return

    print('XML')


def is_json(string):
    return re.search(r'[\'|\"][a-zA-Z]+[\'|\"]:.*,', string) is not None


def parse_tags(string):
    return list(map(lambda tag: str(tag) + '>', re.findall(r'(<\w+).*>', string)))


if __name__ == '__main__':
    main()
