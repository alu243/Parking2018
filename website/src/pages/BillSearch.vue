<template lang="pug">
v-form(ref="form" v-model="valid" lazy-validation)
  v-container(fluid)
    v-layout(row wrap)
      v-flex(xs6 sm6 md3)
        v-autocomplete(v-model="condition.userId" :items="states" label="停車管理員" prepend-icon="person")
      v-flex(xs6 sm6 md3)
        //- v-text-field(v-model="condition.carNo" :rules="nameRules" label="車號" prepend-icon="directions_car" required)
        v-text-field(v-model="condition.carNo" label="車號" prepend-icon="directions_car" required)
      v-flex(xs6 sm6 md3)
        div(class="layout")
          v-icon(style="margin-right:10px") event
          v-datetime-picker(label="時間起值" v-model="condition.startDate" class="v-input__control")
      v-flex(xs6 sm6 md3)
        div(class="layout")
          v-icon(style="margin-right:10px") event
          v-datetime-picker(label="時間訖值" v-model="condition.endDate" class="v-input__control")
      v-flex(xs6 sm6 md6)
         v-btn(small :disabled="!valid" @click="findBillDetails")
           v-icon search
           | 查詢
         v-btn(small @click="clear")
           v-icon clear
           | 清除
  v-card(v-show="bills.length > 0")
    v-container(fluid grid-list-lg)
      v-layout(row wrap)
        v-flex(xs12 v-for="(item, i) in bills" :key="item.BtNo")
            //- v-card(color="i % 2 == 0 ? blue-grey darken-' : cyan darken-0" class="white--text")
            v-card(:color="i % 2 == 0 ? 'blue-grey lighten-2' : 'cyan lighten-1'" class="white--text" :hover="true")
              v-card-text
                v-layout
                  v-flex(xs1)
                    div {{i}}
                  v-flex(xs6 md3)
                    span(class="grey--text text--darken-3") 車號 <br>
                    h1 {{item.CarNo}} <br>
                    span(class="grey--text text--darken-3") 停車日期 <br>
                    h2 {{item.StartDate}}
                    span(class="grey--text text--darken-3") 停車期間 <br>
                    h2 {{item.StartTime}}
                  v-flex(xs5 md3)
                    span(class="grey--text text--darken-3") 開單人員 <br>
                    h2 {{item.Employee}}
                    span(class="grey--text text--darken-3") 開單車格 <br>
                    h2 {{item.Road}}
                  v-flex(xs12 md3)
                    v-img(:src="item.Img" height="168px" position="center center" contain style="border:1")
</template>
        <!-- <v-text-field v-model="email" :rules="emailRules" label="E-mail" required></v-text-field>
      <v-select v-model="select" :items="items" :rules="[v => !!v || 'Item is required']" label="Item" required></v-select>
      <v-checkbox v-model="checkbox" :rules="[v => !!v || 'You must agree to continue!']" label="Do you agree?" required></v-checkbox> -->

<script>
export default {
	name: 'BillSearch',
	props: {
		msg: String,
	},
	data() {
		return {
			userName: null,
			valid: false,
			states: ['王大明', '王小明', '李大雄', '葉小華'],
			carNo: null,
			startDate: null,
			endDate: null,
			bills: [],
			condition: {},
		};
	},
	methods: {
		clear() {
			this.condition = {};
			this.bills = [];
		},
		findBillDetails() {
			this.$http.post('/billdetail', this.condition).then(
				(response) => {
					this.bills = response.data;
				},
				(error) => {
					alert('error');
					alert(error);
				},
			);
		},
	},
};
</script>