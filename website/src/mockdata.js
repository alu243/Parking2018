import axios from 'axios';
import MockAdapter from 'axios-mock-adapter';
export default (() => {
    let mock = new MockAdapter(axios, {
        delayResponse: 1300
    });
    mock.onPost('/billdetail').reply(200, [{
                BtNo: 1,
                CarNo: "ABC-001",
                StartDate: "2018/10/03",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路538",
                Img: "/images/car1.png"
            },
            {
                BtNo: 2,
                CarNo: "ABC-003",
                StartDate: "2018/10/03",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路539",
                Img: "/images/car2.jpg"
            },
            {
                BtNo: 3,
                CarNo: "ABC-004",
                StartDate: "2018/10/03",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路540",
                Img: "/images/car3.jpg"
            },
            {
                BtNo: 4,
                CarNo: "ABC-005",
                StartDate: "2018/10/04",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路541",
                Img: "/images/car4.jpg"
            },
            {
                BtNo: 5,
                CarNo: "ABC-006",
                StartDate: "2018/10/04",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路542",
                Img: "/images/car1.png"
            },
            {
                BtNo: 6,
                CarNo: "ABC-007",
                StartDate: "2018/10/04",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路543",
                Img: "/images/car2.jpg"
            },
            {
                BtNo: 7,
                CarNo: "ABC-008",
                StartDate: "2018/10/05",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路639",
                Img: "/images/car3.jpg"
            },
            {
                BtNo: 8,
                CarNo: "ABC-009",
                StartDate: "2018/10/05",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路629",
                Img: "/images/car4.jpg"
            },
            {
                BtNo: 9,
                CarNo: "ABC-010",
                StartDate: "2018/10/05",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路433",
                Img: "/images/car1.png"
            },
            {
                BtNo: 10,
                CarNo: "ABC-011",
                StartDate: "2018/10/06",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路112",
                Img: "/images/car2.jpg"
            },
            {
                BtNo: 11,
                CarNo: "ABC-012",
                StartDate: "2018/10/06",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路233",
                Img: "/images/car3.jpg"
            },
            {
                BtNo: 12,
                CarNo: "ABC-013",
                StartDate: "2018/10/06",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路462",
                Img: "/images/car4.jpg"
            },
            {
                BtNo: 13,
                CarNo: "ABC-014",
                StartDate: "2018/10/07",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路1539",
                Img: "/images/car1.png"
            },
            {
                BtNo: 14,
                CarNo: "ABC-015",
                StartDate: "2018/10/07",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路392",
                Img: "/images/car2.jpg"
            },
            {
                BtNo: 15,
                CarNo: "ABC-016",
                StartDate: "2018/10/07",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路111",
                Img: "/images/car3.jpg"
            },
            {
                BtNo: 16,
                CarNo: "ABC-017",
                StartDate: "2018/10/08",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路72",
                Img: "/images/car4.jpg"
            },
            {
                BtNo: 17,
                CarNo: "ABC-018",
                StartDate: "2018/10/08",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路712",
                Img: "/images/car1.png"
            },
            {
                BtNo: 18,
                CarNo: "ABC-019",
                StartDate: "2018/10/08",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路114",
                Img: "/images/car2.jpg"
            },
            {
                BtNo: 19,
                CarNo: "ABC-020",
                StartDate: "2018/10/13",
                StartTime: "13:00 ~ 14:00",
                Employee: "陳曉春",
                Road: "五福二路226",
                Img: "/images/car3.jpg"
            },
        ])
        .onGet('/error').reply(500, {
            msg: 'failure'
        }).onAny().passThrough();
})();