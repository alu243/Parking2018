<template lang="pug">
v-form(ref="form" v-model="valid" lazy-validation)
  v-container(fluid)
    v-layout(row wrap)
      v-flex(xs6 sm6 md3)
        v-autocomplete(v-model="userName" :items="states" label="停車管理員" prepend-icon="person")
      v-flex(xs6 sm6 md3)
        v-text-field(v-model="carNo" :rules="nameRules" label="車號" prepend-icon="directions_car" required)
      v-flex(xs6 sm6 md3)
        v-datetime-picker(label="時間起值" v-model="startDate" prepend-icon="event")
      v-flex(xs6 sm6 md3)
        v-datetime-picker(label="時間訖值" v-model="endDate")
      v-flex(xs6 sm6 md6)
         v-btn(small :disabled="!valid" @click="submit")
           v-icon search
           | 查詢
         v-btn(small @click="clear")
           v-icon clear
           | 清除
</template>
        <!-- <v-text-field v-model="email" :rules="emailRules" label="E-mail" required></v-text-field>
      <v-select v-model="select" :items="items" :rules="[v => !!v || 'Item is required']" label="Item" required></v-select>
      <v-checkbox v-model="checkbox" :rules="[v => !!v || 'You must agree to continue!']" label="Do you agree?" required></v-checkbox> -->

<script>
export default {
	name: 'BillSearch',
	props: {
		msg: String
	},
	data() {
		return {
			userName: null,
			states: ['王大明', '王小明', '李大雄', '葉小華'],
			carNo: null,
			startDate: null,
			endDate: null
		}
	}
}
</script>