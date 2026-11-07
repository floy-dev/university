import {animate, splitText, stagger} from './lib/anime.esm.js'
import SlimSelect from './lib/slimselect.js'

// Ждем загрузку страницы
addEventListener('DOMContentLoaded', ev => {
    // анимация лого
    const { chars } = splitText('#logo', { words: false, chars: true });
    animate(chars, {
        y: [
            { to: '-1.25rem', ease: 'outExpo', duration: 600 },
            { to: 0, ease: 'outBounce', duration: 800, delay: 100 }
        ],
        rotate: {
            from: '-1turn',
            delay: 0
        },
        delay: stagger(50),
        ease: 'inOutCirc',
    });

    // анимация карточек
    animate('.card', {
        opacity: [0, 1],
        delay: 200,
        duration: 2000
    })
})

// событие на переход страницы игр
let view_all_games_button = document.querySelector(`.about__view-all`)
if (view_all_games_button) {
    view_all_games_button.addEventListener('click', ev => {
        window.location.href = 'games.php'
    })
}

// событие на переход страницы вопросов
let ask_qa_button = document.querySelector(`.button-ask-qa`)
if (ask_qa_button) {
    ask_qa_button.addEventListener('click', ev => {
        window.location.href = 'contacts.php'
    })
}

// событие на переход страницы встреч
let view_schedule_button = document.querySelector(`.about__view-schedule`)
if (view_schedule_button) {
    view_schedule_button.addEventListener('click', ev => {
        window.location.href = 'schedule.php'
    })
}

// событие выбора категорий
let tabs = document.querySelectorAll('.tab')
if (tabs) {
    tabs.forEach((tab) => {
        tab.addEventListener(`click`, ev => {
            if (ev.target !== undefined) {
                if (ev.target.classList.contains('tab-active')){
                    ev.target.classList.remove('tab-active')
                }
                else{
                    ev.target.classList.add('tab-active')
                }
            }
        })
    })
}

// валидация формы
let form = document.querySelector(`.contacts-form`)
if (form !== null) {
    form.querySelector(`button[type="submit"]`).addEventListener('click', event => {
        event.preventDefault()
        // if (validateForm(form) !== true) {
        //     return;
        // }
        form.submit()
    })
}

// часы
if (document.getElementById('clock') !== null) {
    updateClock();
    setInterval(updateClock, 1000);
}

loadSelect().then(r => {
    const group = document.querySelector('.menu-nav-slim')

    if (!group){
        return
    }
    // отображение выпадающего списка
    group.querySelector('.menu-nav-select')?.classList.remove('hide')
})

function validateForm(){
    let is_valid = true;

    let name = document.getElementById(`name`)
    if (name.value.length < 2 || name.value.length > 10){
        name.classList.add('error')
        name.addEventListener('input', ev => {
            name.classList.remove('error')
        }, {
            once: true
        })
        is_valid = false;
    }

    let email = document.getElementById(`email`)
    let regexp = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!regexp.test(email.value)) {
        email.classList.add('error')
        email.addEventListener('input', ev => {
            email.classList.remove('error')
        }, {
            once: true
        })
        is_valid = false;
    }

    let message = document.getElementById(`message`)
    if (message.value.length > 1000){
        message.classList.add('error')
        message.addEventListener('input', ev => {
            message.classList.remove('error')
        }, {
            once: true
        })
        is_valid = false;
    }

    return is_valid;
}

async function loadSelect(){
    const group = document.querySelector('.menu-nav-slim')

    if (!group || !group.querySelector('select')){
        return
    }

    const slim = new SlimSelect({
        select: group.querySelector('select'),
        settings: {
            showSearch: false,
            contentLocation: group.querySelector('.menu-nav-slim-content'),
            contentPosition: 'relative',
            contentWidth: '>180px',
            modal: 'off'
        },
        data: [
            { text: 'Лесные тропы', value: 'forest_trails' },
            { text: 'Город мастеров', value: 'city_of_craftsmen' },
            { text: 'Слово за слово', value: 'word_by_word' }
        ],
        events: {
            beforeClose: (info) => {
                if (info.option !== undefined) {
                    window.location.href = 'games.php'
                }
            }
        }
    })

    group.querySelector('.menu-trigger').addEventListener('click', (e) => {
        e.stopPropagation()
        slim.settings.isOpen ? slim.close() : slim.open()
    })
}

function updateClock() {
    const now = new Date();

    const hours = String(now.getHours()).padStart(2, '0');
    const minutes = String(now.getMinutes()).padStart(2, '0');
    const seconds = String(now.getSeconds()).padStart(2, '0');

    document.getElementById('clock').textContent = `${hours}:${minutes}:${seconds}`;
}